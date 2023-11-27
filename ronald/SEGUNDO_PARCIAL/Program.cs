﻿namespace Programacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //MostrarDigitosImparesIterativo(78548);
           //MostrarDigImparesRecursivo(78548);
            //MatrizEnteros Matriz = new MatrizEnteros(5, 5);
            
            //Console.WriteLine("---------------------------");

            //Matriz.LlenarMatriz_v1();
            //Matriz.MostrarMatriz();

            int[,] matriz = {
                {5, 2, 1, 1, 1},
                {1, 1, 4, 5, 2},
                {2, 2, 3, 2, 3},
                {9, 8, 6, 7, 4},
                {5, 2, 9, 7, 8}
            };

            ImprimirMatriz(matriz);

            int[] sumaFilas = MatrizUtils.SumarFilas(matriz);

            Console.WriteLine("\nSuma de cada fila:");

            for (int i = 0; i < sumaFilas.Length; i++)
            {
                Console.WriteLine($"Fila {i + 1}: {sumaFilas[i]}");
            }
        } 

        private static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");

                    if (j < matriz.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        /*public static void MostrarDigitosImparesIterativo(int N)
        {
            int NroAux = N;
            while (NroAux != 0)
            {
                int dig = NroAux % 10;
                if(dig % 2 != 0){
                    Console.WriteLine("Dig: " + dig);
                }
                NroAux = NroAux / 10;
            }
        }

        public static void MostrarDigImparesRecursivo(int N){
            int NroAux = N;
            if(NroAux == 0){
                return;
            }else{
                int dig = NroAux % 10;
                if(dig % 2 != 0){
                    Console.WriteLine("Dig: " + dig);
                }
                Console.WriteLine("ANTES => NroAux: " + NroAux);
                MostrarDigImparesRecursivo(NroAux / 10);
                Console.WriteLine("DESPUES => NroAux: " + NroAux);
            }
        }
        */
        
    }
}