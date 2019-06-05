using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_WebApi_SPMEDGROUP.Domains
{
    public class GeoLoc
    {
        public double latitude { get; set; }

        public double longitude { get; set; }
        public string TipoUsuario { get; internal set; }
    }
}
