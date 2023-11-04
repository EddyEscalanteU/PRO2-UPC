using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Resolver una ecuación cuadrática ax^2 + bx + c = 0");
        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double variable = b * b - 4 * a * c;

        if (variable > 0) 
        {
            double x1 = (-b + Math.Sqrt(variable)) / (2 * a);
            double x2 = (-b - Math.Sqrt(variable)) / (2 * a);
            Console.WriteLine("Dos soluciones reales:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (variable == 0)
        {
            double x1 = -b / (2 * a);
            Console.WriteLine("Una solución real única:");
            Console.WriteLine("x1 = " + x1);
        }
        else
        {
            Console.WriteLine("No hay soluciones reales.");
        }
    }
}