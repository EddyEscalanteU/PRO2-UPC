using System;

class Program
{
    static void Main()
    {
        int limite = 10; 
        MostrarImparesRecursivo(1, limite);
    }

    static void MostrarImparesRecursivo(int actual, int limite)
    {
        if (actual <= limite)
        {
            if (actual % 2 != 0)
            {
                Console.WriteLine(actual);
            }

            MostrarImparesRecursivo(actual + 1, limite);
        }
    }
}