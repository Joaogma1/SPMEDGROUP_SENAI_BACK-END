using Senai_WebApi_SPMEDGROUP.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Interfaces
{
  public interface IPacienteRepository
    {

        /// <summary>
        /// Lista os Pacientes do Sistema
        /// </summary>
        /// <returns>Retorna uma Lista de pacientes</returns>
        List<Pacientes> ListarPaciente();
    }
}
