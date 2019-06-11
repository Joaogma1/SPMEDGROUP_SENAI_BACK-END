using Senai_WebApi_SPMEDGROUP.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Interfaces
{
    public interface IConsultaRepository
    {
        /// <summary>
        /// Lista todas consultas Existentes no Sistema
        /// </summary>
        /// <returns> Retorna uma lista com todas as consultas</returns>
        List<Consulta> ListarTodasConsulta();

        /// <summary>
        /// Cadastra uma nova consulta
        /// </summary>
        /// <param name="DadosConsulta"> Deve Ser passado os dados da Consulta</param>
        void cadastrarConsulta(Consulta DadosConsulta);

        /// <summary>
        /// Lista todas consultas de um determinado paciente
        /// </summary>
        /// <param name="Id">ID do Paciente</param>
        /// <returns>Retorna Lista de consultas de um determinado Paciente</returns>
        List<Consulta> ListarConsultasPaciente(int Id);

        /// <summary>
        /// Lista Todas Consultas de um determinado Medico
        /// </summary>
        /// <param name="Id">Id do Medico</param>
        /// <returns>Retorna Lista de Consultas de um determinado Medico</returns>
        List<Consulta> ListarConsultasMedico(int Id);

        Consulta BuscarPorId(int id);

        void AtualizarConsulta(Consulta dadosConsulta);
    }
}
