using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using Senai_WebApi_SPMEDGROUP.Repositories;

namespace Senai_WebApi_SPMEDGROUP.Controlles
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private IPacienteRepository PacienteRepository { get; set; }

        public PacientesController()
        {
            PacienteRepository = new PacienteRepository();
        }

        [HttpGet]
        [Authorize]
                public IActionResult get()
        {
            try
            {
                return Ok(PacienteRepository.ListarPaciente());
            }
            catch 
            {

                return BadRequest();
            }
        }

    }
}