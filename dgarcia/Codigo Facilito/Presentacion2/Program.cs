using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de f es: {0:F2}", f);
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de bandera es: " + fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
