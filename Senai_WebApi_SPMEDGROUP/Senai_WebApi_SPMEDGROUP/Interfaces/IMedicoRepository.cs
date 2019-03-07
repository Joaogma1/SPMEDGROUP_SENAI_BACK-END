using Senai_WebApi_SPMEDGROUP.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Interfaces
{
    public interface IMedicoRepository
    {
        /// <summary>
        /// Lista Todos Medicos Cadastrados no Sistema
        /// </summary>
        /// <returns>Retorna uma lista de Médicos Que estão Cadastrados no Sistema</returns>
        List<Medico> ListarMedicos();


    }
}
