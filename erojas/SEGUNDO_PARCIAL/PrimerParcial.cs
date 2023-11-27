using System;
public class Recursividad
{
 public static void MostrarDigImparesIterativo(int N)
 {
    int NroAux =  N;
    while(NroAux !=0)
    {
        int dig = NroAux % 10;
        if(dig % 2 != 0){
            Console.WriteLine("Dig: " + dig);
        }
        NroAux = NroAux / 10;
    }
 }
 

    public static void MostrarDigImparesRecursivo(int N)
    {
        if (N != 0)
        {
            int dig = N % 10;
            if (dig % 2 != 0)
            {
                Console.WriteLine("Dig: " + dig);
            }
            MostrarDigImparesRecursivo(N / 10);
        }
    }
     private int[,] matriz = new int[5, 5] {
        {1, 6, 4, 2, 7},
        {2, 7, 3, 3, 7},
        {3, 7, 2, 4, 6},
        {4, 6, 1, 5, 5},
        {5, 5, 1, 6, 4}
    };

    public void MostrarMatriz()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public void SumarColumnas()
    {
        for (int j = 0; j < 5; j++)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += matriz[i, j];
            }
            Console.WriteLine("La suma de la columna {0} es {1}", j, suma);
        }
    }
}


