namespace Programacion2
{
    public class MatrizUtils
    {
        public static int[] SumarFilas(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            int[] sumaFilas = new int[filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    sumaFilas[i] += matriz[i, j];
                }
            }

            return sumaFilas;
        }
    }
}