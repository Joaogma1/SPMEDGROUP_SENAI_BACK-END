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
                return ctx.Consulta.Where(x => x.IdMedico == Id).ToList();           /// Se pah roda XD
            }
        }

        public List<Consulta> ListarConsultasPaciente(int Id)
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                return ctx.Consulta.Where(x => x.IdPaciente == Id).ToList();         /// Se isso Aqui Rodar a Karen vai me dar um beijo
            }
        }

        public List<Consulta> ListarTodasConsulta()
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                return ctx.Consulta.ToList();
            }
        }
    }
}
