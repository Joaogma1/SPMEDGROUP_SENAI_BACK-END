using Microsoft.EntityFrameworkCore;
using Senai_WebApi_SPMEDGROUP.Domains;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using Senai_WebApi_SPMEDGROUP.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public Domains.Usuario BuscarPorEmailSenha(String Email, String Senha)
        {

            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                //SqlParameter e = new SqlParameter("@Email", Email);
                //// var s = new SqlParameter("@Senha", Senha);

                Usuario UsuarioBuscado = ctx.Usuario.Where(x => x.Email == Email && x.Senha == Senha).FirstOrDefault();
                UsuarioBuscado.Senha = null;
                return UsuarioBuscado;
            }
        }

        public void Cadastrar(Domains.Usuario usuario)
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                ctx.Usuario.Add(usuario);
                ctx.SaveChanges();
            }
        }
    }
}
