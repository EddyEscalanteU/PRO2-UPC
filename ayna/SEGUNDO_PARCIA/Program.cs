using System;

class Program
{
    static void Main()
    {
        // Definir una matriz de enteros
        int[,] matriz = {
            {5, 2, 1, 1, 1},
            {1, 1, 4, 5, 2},
            {2, 2, 3, 2, 3},
            {9, 8, 6, 7, 4},
            {5, 2, 9, 7, 8}
        };

        // Mostrar la matriz en la consola
        MostrarMatriz(matriz);

        // Calcular y mostrar la suma por columna en la consola
        SumarYMostrarPorColumna(matriz);
    }

    // Método para mostrar la matriz en la consola
    static void MostrarMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Matriz:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                // Mostrar el elemento actual de la matriz seguido de una pestaña
                Console.Write(matriz[i, j] + "\t");
            }
            // Cambiar de línea después de mostrar todos los elementos de una fila
            Console.WriteLine();
        }
    }

    // Método para calcular y mostrar la suma por columna en la consola
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
                // Calcular la suma de los elementos en la columna actual
                sumaColumna += matriz[i, j];
            }

            // Mostrar la suma de la columna actual
            Console.WriteLine($" fila {j + 1}: {sumaColumna}");
        }
    }
}
