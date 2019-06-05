using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Interfaces
{
    public interface IGeolocalizacaoRepository
    {
        /// <summary>
        /// Cadastra Localização de um médico com especialidade 
        /// em breve !
        /// </summary>
        /// <param name="latitude"> Medida de latitude</param>
        /// <param name="longitude">Medida de Longitude</param>
        /// <param name="TipoUsuario"> Tipo de usuário referente a quem enviou a solicitação</param>
        /// <param name="especialidade"> Especialidade do médico</param>
        void cadastrarLoc(double latitude, double longitude , String TipoUsuario, String especialidade);
        
        /// <summary>
        ///  Cadastra localiza de outros tipos de usuarios 
        /// </summary>
        /// <param name="latitude">Medida de latitude</param>
        /// <param name="longitude">Medida de Longitude</param>
        /// <param name="TipoUsuario">Tipo de usuário referente a quem enviou a solicitação</param>
        void cadastrarLoc(double latitude, double longitude, String TipoUsuario);

    }
}
