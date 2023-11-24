using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClaseArra A = new ClaseArra(5);
            A.ArrayEnteros[0] = 1;
            A.ArrayEnteros[1] = 9;
            A.ArrayEnteros[2] = 10;
            A.ArrayEnteros[3] = 2;
            A.ArrayEnteros[4] = 7;
            A.MostrarArray();
            Console.WriteLine("-------------------");
            ClaseArra B = new ClaseArra(3);

            B.ArrayEnteros[0] = 10;
            B.ArrayEnteros[1] = 90;
            B.ArrayEnteros[2] = 100;
            B.MostrarArray();

            /*A.SumarElementosArray();
            B.SumarElementosArray();
            */

            /*A.MostraMaxMinArrayEnteros();
            
            A.PromedioArrayEnteros();

            A.FrecuenciaArrayEnteros(5);
            */


            ClaseArray A1 = new ClaseArray(5);
            A1.ArrayCadenas[0] = "Ereli";
            A1.ArrayCadenas[1] = "Mario";
            A1.ArrayCadenas[2] = "Lucia";
            A1.ArrayCadenas[3] = "Liliana";
            A1.ArrayCadenas[4] = "Carlos";
            A1.MostrarArray();
            ClaseArray B1 = new ClaseArray(5);
            B1.ArrayCadenas[0] = "Ereli";
            B1.ArrayCadenas[1] = "Ricardo";
            B1.ArrayCadenas[2] = "Lucia";
            B1.ArrayCadenas[3] = "Liviana";
            B1.ArrayCadenas[4] = "Julio";
            B1.MostrarArray();
            A1.DiferenciaArrayCadenasAyB(B1);

            Console.WriteLine(A1);

            
        }
    }
}
