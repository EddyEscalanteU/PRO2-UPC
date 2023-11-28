public class SegundoParcial{
public static void Main()
    {
        int[,] matriz = {
            {5, 2, 1, 1, 1},
            {1, 1, 4, 5, 2},
            {2, 2, 3, 2, 3},
            {9, 8, 6, 7, 4},
            {5, 2, 9, 7, 8}
        };

        SumarFilas(matriz);
    }

    static void SumarFilas(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            int sumaFila = 0;

            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[j, i];
            }

            Console.WriteLine($"Suma de la fila {i + 1}: {sumaFila}");
        }
    }
    }