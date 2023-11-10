using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            clsClientesConContacto cliente = new clsClientesConContacto (0, "Marcos Hernandez", "001", "HEHM", 1, "Marcos Hernandez",
                "23333", "md@gmail.com", " ", "Av Trigre", "119", "254",  "La cueva del jaguar", "Tuxtla Gutierrez", "Chiapas", "2996");

            intSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
                Impresion = new clsImpresion();
            else
                Impresion = new clsArchivos();
            Impresion.ImprimeCliente(cliente);

        }
    }
}
