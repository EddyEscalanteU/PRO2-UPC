using System;

public class OrdenamientoDescendente
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };
        Console.WriteLine("Lista sin Ordenamiento ");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine("\n");
        Array.Sort(arr);
        Array.Reverse(arr);
        Console.WriteLine("Lista ordenada de forma Descendente: ");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }
}