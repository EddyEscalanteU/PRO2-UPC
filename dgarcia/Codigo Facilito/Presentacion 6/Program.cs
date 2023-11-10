using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion_6
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Hernadez Hernandez";
            Cliente.Nombres = "Marcos";
            Cliente.RFC = "HERM";
            Cliente.Direccion = "Ave Tigre 119";
            Cliente.Colonia = "La cueva del jaguar";
            Cliente.Municipio = "Tuxtla Gutierrez";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito) 
            Console.WriteLine("El cliente tiene credito");
            else Console.WriteLine("El cliente no tiene credito");
            Console.ReadLine();    


        }
    }
}
