using Senai_WebApi_SPMEDGROUP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FireSharp;

using FireSharp;
using FireSharp.Config;
using FireSharp.EventStreaming;
using FireSharp.Exceptions;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Serialization;
using FireSharp.Serialization.JsonNet;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Senai_WebApi_SPMEDGROUP.Domains;

namespace Senai_WebApi_SPMEDGROUP.Repositories
{
    public class GeolocalizacaoRepository : IGeolocalizacaoRepository
    {
        protected const string BasePath = "https://spmedgroup-xd.firebaseio.com";
        protected const string FirebaseSecret = "lpkHTnIhoSYY6tWZE84Um4pAv5SvoVyWyAvCuWfi";
        private IFirebaseClient _client;
        
        public void cadastrarLoc(double latitude, double longitude, string TipoUsuario, string especialidade)
        {
            throw new NotImplementedException();
        }

        public void cadastrarLoc(double latitude, double longitude, string TipoUsuario)
        {
            var data = new GeoLoc
            {
                latitude = latitude,
                longitude = longitude,
                TipoUsuario = TipoUsuario
            };
            try
            {
                IFirebaseConfig config = new FirebaseConfig
                {
                    AuthSecret = FirebaseSecret,
                    BasePath = BasePath
                };
                _client = new FirebaseClient(config);

                _client.Push("/Localizacao_Usuarios",data);
            }
            catch (Exception erro)
            {
            }
        }
    }
}
