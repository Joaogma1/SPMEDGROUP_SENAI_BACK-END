using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ConsultasController : ControllerBase
    {
        private IConsultaRepository ConsultaRepository { get; set; }

        public ConsultasController()
        {
            ConsultaRepository = new ConsultaRepository();
        }

        /// <summary>
        /// Cadastra uma nova consulta no sistema
        /// </summary>
        /// <param name="DadosConsulta">Dados da consulta</param>
        /// <returns>Void tem retorno ?</returns>
        [HttpPost]
        public IActionResult Post(Consulta DadosConsulta)
        {
            try
            {
                ConsultaRepository.cadastrarConsulta(DadosConsulta);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        /// <summary>
        ///  Busca por todas as consultas do Paciente
        /// </summary>
        /// <param name="Id"> Id do paciente que as consultas serao buscadas</param>
        /// <returns>Retorna Uma lista de consultas de determinado Paciente</returns>
        [HttpGet("{Id}")]
        public IActionResult getConsultas(int Id)
        {
            try
            {
                return Ok(ConsultaRepository.ListarConsultasPaciente(Id));
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }


        /// <summary>
        /// Busca por todas consultas de determinado Medico
        /// </summary>
        /// <param name="Id">Id do medico consultado</param>
        /// <returns>Retorna Uma lista de consultas de determinado Medico</returns>
        [HttpGet("{Id}")]
        public IActionResult getMedicos(int Id)
        {
            try
            {
                return Ok(ConsultaRepository.ListarConsultasMedico(Id));
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
        /// <summary>
        /// Lista todas as Consultas Existentes
        /// </summary>
        /// <returns> Retorna uma lista com todas as consultas</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(ConsultaRepository.ListarTodasConsulta());
            }
            catch (Exception ex) /// Deixa ai pra testar
            {

                return BadRequest();
            }
        }
    }
}