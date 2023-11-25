public class MatrizUtils
{
    public static int[] SumarElementosColumnas(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int[] sumaColumnas = new int[columnas];

        for (int j = 0; j < columnas; j++)
        {
            int suma = 0;
            for (int i = 0; i < filas; i++)
            {
                suma += matriz[i, j];
            }
            sumaColumnas[j] = suma;
        }

        return sumaColumnas;
    }
}