using Senai_WebApi_SPMEDGROUP.Domains;
using Senai_WebApi_SPMEDGROUP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Interfaces
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="usuario">UsuarioDomain</param>
        void Cadastrar(Domains.ViewModels usuario);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        LoginViewModel BuscarPorEmailSenha(LoginViewModel Login);


    }
}
