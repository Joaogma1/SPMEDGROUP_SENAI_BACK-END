using System;
using System.Collections.Generic;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public partial class EnderecoClinica
    {
        public EnderecoClinica()
        {
            Clinica = new HashSet<Clinica>();
        }

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }

        public ICollection<Clinica> Clinica { get; set; }
    }
}
