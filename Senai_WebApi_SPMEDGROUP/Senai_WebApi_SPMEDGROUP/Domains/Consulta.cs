using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public partial class Consulta
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        [Required]
        public DateTime DataConsulta { get; set; }
        public string StatusConsulta { get; set; }
        public string Descricao { get; set; }

        public Medico IdMedicoNavigation { get; set; }
        public Pacientes IdPacienteNavigation { get; set; }
    }
}
