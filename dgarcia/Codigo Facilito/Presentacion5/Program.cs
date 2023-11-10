using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados();
            empleado.Edad = 25;
            empleado.Nombre = "Marcos Fernandez";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado " + empleado.Nombre);
            Console.WriteLine("es: " +  total.ToString("C"));
            Console.ReadKey();
        }
    }
}
