using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using Senai_WebApi_SPMEDGROUP.Repositories;

namespace Senai_WebApi_SPMEDGROUP.Controlles
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
        private IMedicoRepository MedicosRepository { get; set; }


        public MedicosController()
        {
            MedicosRepository = new MedicoRepository();
        }
        [HttpGet]
        [Authorize(Roles = "administrador")]

        public IActionResult get()
        {
            try
            {
                return Ok(MedicosRepository.ListarMedicos());
            }
            catch 
            {

                return  BadRequest();
            }
        }
    }
}