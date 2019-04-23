using Microsoft.EntityFrameworkCore;
using Senai_WebApi_SPMEDGROUP.Domains;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public List<Medico> ListarMedicos()
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                return ctx.Medico.Include(x => x.IdEspecialidadeNavigation).ToList();
            }
        }
    }
}
