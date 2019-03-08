using System;
using System.Collections.Generic;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdEspecialidade { get; set; }
        public int IdClinica { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }

        public Clinica IdClinicaNavigation { get; set; }
        public Especialidade IdEspecialidadeNavigation { get; set; }
        public ViewModels IdUsuarioNavigation { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
