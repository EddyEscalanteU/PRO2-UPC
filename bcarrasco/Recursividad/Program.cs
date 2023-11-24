﻿namespace Programacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //long f = Factorial(64);
           //Console.WriteLine(f);
           GenerarSerieV1Recursivo(10);
        }   
        
        public static long Factorial(long n){
            if(n < 0){
                return 0;//ERROR
            }else{
                if(n == 0 || n == 1){
                    Console.WriteLine("FIN de la recursion");
                    return 1;
                }else{
                    long fact =  n * Factorial(n-1);
                    Console.WriteLine(n + " Llamada a la recursion " + fact);
                    return fact;
                    //Console.WriteLine("Despues de la recursion");
                }
            }
        }  
  
        public static void MostrarDigIterativo(int N)
        {
            int NroAux = N;
            while (NroAux != 0)
            {
                int dig = NroAux % 10;
                Console.WriteLine("Dig: " + dig);
                NroAux = NroAux / 10;
            }
        }

        public static void MostrarDigRecursivo(int N){
            int NroAux = N;
            if(NroAux == 0){
                return;
            }else{
                int dig = NroAux % 10;
                Console.WriteLine("Dig: " + dig);
                MostrarDigRecursivo(NroAux / 10);
            }
        }

        public static void MostrarDigParesIterativo(int N)
        {
            int NroAux = N;
            while (NroAux != 0)
            {
                int dig = NroAux % 10;
                if(dig % 2 == 0){
                    Console.WriteLine("Dig: " + dig);
                }
                NroAux = NroAux / 10;
            }
        }
        
        public static void MostrarDigParesRecursivo(int N){
            int NroAux = N;
            if(NroAux == 0){
                return;
            }else{
                int dig = NroAux % 10;
                if(dig % 2 == 0){
                    Console.WriteLine("Dig: " + dig);
                }
                Console.WriteLine("ANTES => NroAux: " + NroAux);
                MostrarDigParesRecursivo(NroAux / 10);
                Console.WriteLine("DESPUES => NroAux: " + NroAux);
            }
        }


        namespace Programacion2jass
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //long f = Factorial(64);
           //Console.WriteLine(f);
           GenerarSerieV1Recursivo(6);
        }   
        static int A = 0;
        static int B = 7;
         public static void GenerarSerieV1Recursivo(int N){
            
            if(N == 0){
                return;
            }else{
                GenerarSerieV1Recursivo(N - 1); 
                int serie1 = A + 1;
                int serie2 = B - 1;
                Console.WriteLine("Serie: " + serie1);
                Console.WriteLine("Serie: " + serie2);
                A = serie1;    
                B = serie2;
            }
        }


    }
}