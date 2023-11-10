using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[12];
            int i;
            string Cadena;
            for (i = 0; i < 12; i++)
            {
                Cadena = Console.ReadLine();
                Arreglo[i] = Convert.ToInt32(Cadena);
            }
            for (i = 0;i < 12; i++) 
            {
                Console.WriteLine("{0}", Arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
