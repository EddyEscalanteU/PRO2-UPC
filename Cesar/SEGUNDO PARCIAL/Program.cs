using System;

class Program
{
   /* static void Main()
    {
        // Puedes ingresar el número que desees para probar la función
        int numero = 12345;
        MostrarDigImparesRecursivos(numero);
    }

    public static void MostrarDigImparesRecursivos(int N)
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
    }*/

    static void MostrarTablero(string[,] tablero)
    {
        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                Console.Write(tablero[fila, columna]);
            }
            Console.WriteLine();
        }
    }
}

