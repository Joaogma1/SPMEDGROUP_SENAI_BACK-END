using Senai_WebApi_SPMEDGROUP.Domains;
using Senai_WebApi_SPMEDGROUP.Interfaces;
using Senai_WebApi_SPMEDGROUP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public LoginViewModel BuscarPorEmailSenha(LoginViewModel Login)
        {
            throw new NotImplementedException();
        }

        //public LoginViewModel BuscarPorEmailSenha(LoginViewModel login)
        //{
        //    using (SPMedGroupContext ctx = new SPMedGroupContext())
        //    {
        //        return ctx.Usuario.FirstOrDefault(user => user.Email == login.Email && user.Senha == login.Senha);
        //    }
        //}

        public void Cadastrar(Domains.ViewModels usuario)
        {
            using (SPMedGroupContext ctx = new SPMedGroupContext())
            {
                ctx.Usuario.Add(usuario);
                ctx.SaveChanges();
            }
        }
    }
}
