using System.Collections.Generic;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public partial class ViewModels
    {
        public ViewModels()
        {
            Medico = new HashSet<Medico>();
            Paciente = new HashSet<Pacientes>();
        }

        public int Id { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public ICollection<Medico> Medico { get; set; }
        public ICollection<Pacientes> Paciente { get; set; }
    }
}
