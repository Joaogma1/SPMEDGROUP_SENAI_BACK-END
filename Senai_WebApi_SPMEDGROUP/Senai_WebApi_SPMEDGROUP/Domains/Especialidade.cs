using System;
using System.Collections.Generic;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medico = new HashSet<Medico>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Medico> Medico { get; set; }
    }
}
