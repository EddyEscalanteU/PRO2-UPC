using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    public interface intSalidas
    {
        void ImprimeCliente(clsAbsClientes cliente);

        void ImprimeDireccion(clsDirecciones direccion);
    }
}
