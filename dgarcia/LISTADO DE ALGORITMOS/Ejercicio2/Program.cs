using System;

public class SumaDeArray
{
    public static void Main()

    {
        int[] Myarray = { 4, 8, 5, 7 };
        int sum = 0;
        Array.ForEach(Myarray, i => sum += i);

        Console.WriteLine("Ejercicio 2: ");

        Console.WriteLine("La suma de enteros de este Array es: " + sum);
    }
    public class Example
    {
    }
}

