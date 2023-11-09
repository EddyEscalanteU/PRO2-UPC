using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion2
{
class Program
{
    static void public static void Main(string[] args)
    {
        int i = 0;
        decimal x = 0.m;
        float f = 0.0f;
        double d = 0.0D;
        string cadena = "Hola mundo";
        bool badera = false;
        DateTime fecha = DateTime.MainValue;
        Console.WhiteLine("El valor de i es: {0}", i);
        Console.WhiteLine("El valor de x es: {0:C}", x);
        Console.WhiteLine("El valor de f es: {0:F2}",f);
        Console.WhiteLine("El valor de d es: {0:F2}",d);
        Console.WhiteLine("El valor de cadena es: " + cadena);
        Console.WhiteLine("El valor de badera es:" + badera.ToString());
        Console.WhiteLine("El valor de fecha es:" + fecha.ToShortDateString());
        Console.ReadKey();
        
    }
}
}