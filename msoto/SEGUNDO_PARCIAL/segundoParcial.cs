using System;

class SumarElementos
{
    private int[,] matriz;

    public SumarElementos(int[,] matriz)
    {
        this.matriz = matriz;
    }

    public void SumarElementosPorFila()
    {
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            int sumaFila = 0;
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                sumaFila += matriz[fila, columna];
            }
            Console.WriteLine("La suma de los elementos de la fila {fila + 1} es: {sumaFila}");
        }
    }
}
