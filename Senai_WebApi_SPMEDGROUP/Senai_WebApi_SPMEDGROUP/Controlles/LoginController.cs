using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Senai_WebApi_SPMEDGROUP.Domains;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using Senai_WebApi_SPMEDGROUP.Repositories;
using Senai_WebApi_SPMEDGROUP.ViewModels;

namespace Senai_WebApi_SPMEDGROUP.Controlles
{
    [Produces("Application/Json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public LoginController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult RealizarLogin(LoginViewModel DadosLogin)
        {
            try
            {
                Usuario Usuario = UsuarioRepository.BuscarPorEmailSenha(DadosLogin.Email, DadosLogin.Senha);
                if (Usuario == null)
                {
                    return NotFound();
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, Usuario.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Usuario.Id.ToString()),
                    new Claim(ClaimTypes.Role, Usuario.IdTipoUsuarioNavigation.Tipo.ToString())
                };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("SPMedGroup-Auth-key"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "SPMedGroup.WebApi",
                    audience: "SPMedGroup.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: creds);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch 
            {
                return BadRequest();
            }
        }
    }
}