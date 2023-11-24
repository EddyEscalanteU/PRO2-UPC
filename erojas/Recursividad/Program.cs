namespace Programacion2
{
    public class Program{
        public static void Main(string[]args)
        {
            //int f = Factorial(5);
            //Console.WriteLine(f);
            MostrarDigParesRecursivo(10);
            
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
        public static void MostrarDigIterativo (int N)
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
        public static void GenerarSerieV1Iterativo(int N){
            int i = 1;
            while(N > 0){
                int serie = i + 5;
                Console.WriteLine("Serie: " + serie); 
                i = serie;  
                N = N - 1;             
            }
        }
        static int i = 1;
        public static void GenerarSerieV1Recursivo(int N){
             
           if (N==0){
            return;
            } else{                 
            int serie = i + 5;
            Console.WriteLine("Serie: " + serie);
            GenerarSerieV1Recursivo(N - 1);
            i = serie;
            }
        }
    } 
}

