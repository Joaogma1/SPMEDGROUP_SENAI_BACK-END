using Microsoft.EntityFrameworkCore;
using Senai_WebApi_SPMEDGROUP.Domains;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public void cadastrarConsulta(Consulta DadosConsulta)
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                ctx.Consulta.Add(DadosConsulta);
                ctx.SaveChanges();
            }
        }

        public List<Consulta> ListarConsultasMedico(int Id)
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                return ctx.Consulta.Include(x => x.IdMedicoNavigation).Include(y => y.IdPacienteNavigation).Where(x => x.IdMedico == Id).Include(x => x.IdMedicoNavigation).Include(y => y.IdPacienteNavigation).ToList();
            }
        }

        public List<Consulta> ListarConsultasPaciente(int Id)
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                return ctx.Consulta.Include(x => x.IdMedicoNavigation).Include(y => y.IdPacienteNavigation).Where(x => x.IdPaciente == Id).ToList();         
            }
        }

        public List<Consulta> ListarTodasConsulta()
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                return ctx.Consulta.Include(x => x.IdMedicoNavigation).Include(y => y.IdPacienteNavigation).ToList();
            }
        }
    }
}
