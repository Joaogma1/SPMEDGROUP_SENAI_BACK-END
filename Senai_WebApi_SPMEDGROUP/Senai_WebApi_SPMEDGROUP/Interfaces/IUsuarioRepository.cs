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
        void Cadastrar(Domains.Usuario usuario);

        /// <summary>
        /// Busca usuario usando Email e senha
        /// </summary>
        /// <param name="email">Email Usuario</param>
        /// <param name="senha">Senha Usuario</param>
        /// <returns>Retorna dados do usuario</returns>
        Usuario BuscarPorEmailSenha(string Email, string Senha);


    }
}
