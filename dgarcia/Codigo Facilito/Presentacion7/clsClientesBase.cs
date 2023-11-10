using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    public class clsClientesBase : clsAbsClientes
    {
        public clsClientesBase()
        {
            Id = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            RFC = string.Empty;
            TipoRegimen = 0;
            NombreContacto = string.Empty;
        }

        public clsClientesBase(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen, string pNombreCompleto)
        {
            Id= pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC; 
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreCompleto;
        }
        public override int Id { get; set; }

        public override string Nombre { get; set; }

        public override string Clave { get; set; }

        public override string RFC { get; set; }

        public override int TipoRegimen { get; set; }

        public override string NombreContacto { get; set; }
    }
}
