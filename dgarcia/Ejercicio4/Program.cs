class Program
{
    static void Main()
    {
        // Generar y mostrar una matriz de 5 filas y 5 columnas
        int[,] matrizGenerada = GenerarMatriz(5, 5);
        MostrarMatriz(matrizGenerada);
    }

    static int[,] GenerarMatriz(int filas, int columnas)
    {
        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                // Lógica para determinar qué valores asignar a la matriz
                matriz[i, j] = EsCuadradoInterior(i, j, filas, columnas) ? 1 : 0;
            }
        }

        return matriz;
    }

    static void MostrarMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool EsCuadradoInterior(int fila, int columna, int filas, int columnas)
    {
        int bordeSuperior = filas / 4;
        int bordeInferior = filas - bordeSuperior - 1;
        int bordeIzquierdo = columnas / 4;
        int bordeDerecho = columnas - bordeIzquierdo - 1;

        return fila >= bordeSuperior && fila <= bordeInferior &&
               columna >= bordeIzquierdo && columna <= bordeDerecho;
    }
}

