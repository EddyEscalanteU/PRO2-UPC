﻿namespace Programacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
           RecursivoDomino(7);
        }   
        static int A = 0;
        static int B = 7;
         public static void RecursivoDomino(int N){
            
            if(N == 0){
                return;
            }else{
                //Console.WriteLine("Mostrar antes " + A);
                //Console.WriteLine("Mostrar antes " + B);
                RecursivoDomino(N - 1); 
                //Console.WriteLine("mostrar N: " + N);
                int serieA = A + 1;
                int serieB = B - 1;
                A = serieA;    
                B = serieB;
                Console.WriteLine("Mostrar MEdio: " + serieA);
                Console.WriteLine("Mostrar MEdio: " + serieB);
                //Console.WriteLine("Mostrar despues " + A);
                //onsole.WriteLine("Mostrar despues " + B);
            }
        }


    }
}