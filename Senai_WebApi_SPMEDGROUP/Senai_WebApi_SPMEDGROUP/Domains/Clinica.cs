using System;
using System.Collections.Generic;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medico = new HashSet<Medico>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpnj { get; set; }
        public int IdEndereço { get; set; }
        public string RazaoSocial { get; set; }
        public string HorarioFuncionamento { get; set; }

        public EnderecoClinica IdEndereçoNavigation { get; set; }
        public ICollection<Medico> Medico { get; set; }
    }
}
