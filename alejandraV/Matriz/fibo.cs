using System;

class MiClaseConAlgoritmo
{
    private int[,] M; // Asegúrate de inicializar esta matriz antes de usarla
    private int columna; // Asegúrate de inicializar esta variable antes de usarla
    private int fila; // Asegúrate de inicializar esta variable antes de usarla

    public void MatrizSerie_MasUno()
    {
        int datoPrevioA = 0;
        int datoPrevioB = 1;
        int dato = 0;

        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                dato = datoPrevioA + datoPrevioB;
                M[x, y] = dato;

                datoPrevioA = datoPrevioB;
                datoPrevioB = dato;
            }
        }
    }

    public void ImprimirMatriz()
    {
        for (int y = 0; y < fila; y++)
        {
            for (int x = 0; x < columna; x++)
            {
                Console.Write($"{M[x, y]} ");
            }
            Console.WriteLine();
        }
    }
}