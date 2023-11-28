using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            {5, 2, 1, 1, 1},
            {1, 1, 4, 5, 2},
            {2, 2, 3, 2, 3},
            {9, 8, 6, 7, 4},
            {5, 2, 9, 7, 8}
        };

        MostrarMatriz(matriz);
        SumarYMostrarPorColumna(matriz);
    }

    static void MostrarMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Matriz:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void SumarYMostrarPorColumna(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        Console.WriteLine("\nSuma por columna:");

        for (int j = 0; j < columnas; j++)
        {
            int sumaColumna = 0;

            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }

            Console.WriteLine($"Filas {j + 1}: {sumaColumna}");
        }
    }
}

