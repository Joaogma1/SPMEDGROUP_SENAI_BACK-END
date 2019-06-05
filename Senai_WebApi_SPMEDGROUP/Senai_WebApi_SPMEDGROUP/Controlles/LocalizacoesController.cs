using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_WebApi_SPMEDGROUP.Domains;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using Senai_WebApi_SPMEDGROUP.Repositories;

namespace Senai_WebApi_SPMEDGROUP.Controlles
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizacoesController : ControllerBase
    {
        private IGeolocalizacaoRepository GeolocalizacaoRepository { get; set; }

        /// <summary>
        ///  Método construtor da classe que utiliza polimorfismo para implementar o repositório de Localizacao
        /// </summary>
        public LocalizacoesController()
        {
            GeolocalizacaoRepository = new GeolocalizacaoRepository();
        }
        [HttpPost]
        public IActionResult CadastrarLocalizacao(GeoLoc localizacao)
        {
            try
            {

                String TipoDeUsuario = (HttpContext.User.Claims.First
                    (c => c.Type == ClaimTypes.Role).Value);

                    GeolocalizacaoRepository.cadastrarLoc(localizacao.latitude, localizacao.longitude, TipoDeUsuario);
                
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "erro: " + ex });
            }
        }
    }
}