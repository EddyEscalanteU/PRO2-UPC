using System;

public class Program
{
    public static void Main()
    {
        int numero = 1234567;

        Console.WriteLine("Dígitos impares:");
        MostrarDigImparesRecursivo(numero);
    }

    public static void MostrarDigImparesRecursivo(int N)
    {
        MostrarDigImparesRecursivos(N);
    }

    private static void MostrarDigImparesRecursivos(int N)
    {
        if (N != 0)
        {
            int dig = N % 10;
            if (dig % 2 != 0)
            {
                Console.WriteLine("Dig: " + dig);
            }
            MostrarDigImparesRecursivos(N / 10);
        }
    }

    
}
