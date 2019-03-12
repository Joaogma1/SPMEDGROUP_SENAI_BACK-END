using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medico = new HashSet<Medico>();
        }
        
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpnj { get; set; }
        [Required]
        public int IdEndereço { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        public string HorarioFuncionamento { get; set; }

        public EnderecoClinica IdEndereçoNavigation { get; set; }
        public ICollection<Medico> Medico { get; set; }
    }
}
