using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    public class clsDirecciones
    {
        public clsDirecciones()
        {
            Calle = string.Empty;
            NumeroExterior = string.Empty;
            NumeroInterior = string.Empty;
            Colonia = string.Empty;
            Municipio = string.Empty;
            Estado = string.Empty;
            CP = string.Empty;
        }
        public string Calle { get; set; }

        public string NumeroExterior { get; set; }

        public string NumeroInterior { get;set; }

        public string Colonia { get; set;}

        public string Municipio { get; set;}

        public string Estado { get; set;}

        public string CP { get; set;}

    }

}
