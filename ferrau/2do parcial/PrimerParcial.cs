public class MainClass
{
    public static void Main(string[] args)
    {
        // Declara la matriz
        int[,] matriz = new int[5, 5];

        // Inicializa la matriz
        InicializarMatriz(matriz);

        // Muestra la matriz
        MostrarMatriz(matriz);

        // Suma cada fila de la matriz
        int[] sumas = new int[5];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            sumas[i] = SumarFila(matriz, i);
        }

        // Imprime las sumas de cada fila
        for (int i = 0; i < sumas.Length; i++)
        {
            Console.WriteLine("La suma de la fila " + (i + 1) + " es " + sumas[i]);
        }
    }

    private static void InicializarMatriz(int[,] matriz)
    {
        // Asigna los valores a la matriz
        matriz[0, 0] = 5;
        matriz[0, 1] = 1;
        matriz[0, 2] = 2;
        matriz[0, 3] = 9;
        matriz[0, 4] = 5;

        matriz[1, 0] = 2;
        matriz[1, 1] = 1;
        matriz[1, 2] = 2;
        matriz[1, 3] = 8;
        matriz[1, 4] = 2;

        matriz[2, 0] = 1;
        matriz[2, 1] = 4;
        matriz[2, 2] = 3;
        matriz[2, 3] = 6;
        matriz[2, 4] = 9;

        matriz[3, 0] = 1;
        matriz[3, 1] = 5;
        matriz[3, 2] = 2;
        matriz[3, 3] = 7;
        matriz[3, 4] = 7;

        matriz[4, 0] = 1;
        matriz[4, 1] = 2;
        matriz[4, 2] = 3;
        matriz[4, 3] = 4;
        matriz[4, 4] = 8;
    }

    private static void MostrarMatriz(int[,] matriz)
    {
        // Se recorre la matriz fila por fila
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Se recorre la fila columna por columna
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Se imprime el valor de la celda actual
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static int SumarFila(int[,] matriz, int fila)
    {
        // Se inicializa la suma con 0
        int suma = 0;

        // Se recorre la fila columna por columna
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            // Se suma el valor de la celda actual a la suma
            suma += matriz[fila, j];
        }

        // Se devuelve la suma
        return suma;
    }
}