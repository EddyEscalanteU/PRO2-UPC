using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    public abstract class clsAbsClientes
    {
        public abstract int Id { get; set; }

        public  abstract string Nombre { get; set; }

        public abstract string Clave { get; set; }

        public abstract string RFC { get; set; }

        public abstract int TipoRegimen { get; set; }

        public abstract string NombreContacto { get; set; }


    }
}
