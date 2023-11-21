using System;

public class Ejemplo_05_10a
{

    public static long Factorial(int n) 
    {
        if (n==1)              
            return 1;
        return n * Factorial(n-1);  
    }

    public static void Main()
    {
        int num;
        Console.WriteLine("Introduzca un número: ");
        num = Convert.ToInt32(System.Console.ReadLine()); 
        Console.WriteLine("Su factorial es: {0}", Factorial(num));
    }
  
}