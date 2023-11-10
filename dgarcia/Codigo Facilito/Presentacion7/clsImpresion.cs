using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    public class clsImpresion : intSalidas
    {
        public void ImprimeCliente(clsAbsClientes cliente)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.TipoRegimen == 1)
                Console.WriteLine("Tipo: PERSONA FISICA");
            else
                Console.WriteLine("Tipo: PERSONA MORAL");
            Console.WriteLine("RFC: " + cliente.RFC);
            Console.ReadKey();
        }

        public void ImprimeDireccion(clsDirecciones Direccion)
        {
            Console.WriteLine(Direccion.Calle + " No " + Direccion.NumeroExterior);
            Console.WriteLine(Direccion.Colonia);
            Console.WriteLine(Direccion.CP);
            Console.WriteLine(Direccion.Estado);
        }
    }
}
