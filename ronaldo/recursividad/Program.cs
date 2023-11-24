namespace Programacion2
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            //long f = Factorial (50);
            //Console.WriteLine(f);
            //MostrarDigIterativo(1151814);
            //MostrarDigRecursivo(1151814);
            //MostrarDigParesIterativo(1151814);
            //MostrarDigImparesIterativo(1151814);
            MostrarDigParesRecursivo(1151814);
            //MostrarDigImparesRecursivo(1151418);
        }
        public static long  Factorial(long n)
    {
        if (n < 0)
        {
            return 0;//ERROR
        }
        else
        {
            if(n == 0 || n== 1)
            {
            // este es solo para tener un enunciantes antes del numero
            Console.WriteLine("Fin de la Recursion");
                return 1;
            }
        else
        {
            
            long fact = n * Factorial( n - 1);
            Console.WriteLine("Llamado a la recusion"+ fact);
            return fact;
            //console.writeline("despues de la recursion")
        }
        }
    }
    
// en aca nos muestran los digitos del numero dado al reves del 1151814 lo muestran en 4181511
    public static void  MostrarDigIterativo(int N)
        {
        int  NroAux = N;
        while(NroAux != 0)
            {
            int dig = NroAux % 10;
            Console.WriteLine("Dig :" + dig);
            NroAux = NroAux / 10;
            }
        }

        public static void  MostrarDigRecursivo(int N)
    {
        int  NroAux = N;
        if(NroAux == 0)
        {
            return;
        }
        else
        {
            int dig = NroAux % 10;
            Console.WriteLine("Dig :" + dig);
            MostrarDigRecursivo(NroAux / 10);
        }
    }

    public static void  MostrarDigParesIterativo(int N)
        {
        int  NroAux = N;
        while(NroAux != 0)
            {
            int dig = NroAux % 10;
            if(dig % 2 == 0 )
            {
                Console.WriteLine("Dig :" + dig);
            }
            NroAux = NroAux / 10;
            }
        }

        public static void  MostrarDigImparesIterativo(int N)
        {
        int  NroAux = N;
        while(NroAux != 0)
            {
            int dig = NroAux % 10;
            if(dig % 2 != 0 )
            {
                Console.WriteLine("Dig :" + dig);
            }
            NroAux = NroAux / 10;
            }
        }

    public static void  MostrarDigParesRecursivo(int N)
    {
        int  NroAux = N;
        if(NroAux == 0)
        {
            return;
        }
        else
        {
            int dig = NroAux % 10;
            if(dig % 2 == 0)
            {
                Console.WriteLine("Dig :" + dig);
            }
            Console.WriteLine("Antes => NroAux : " + NroAux); // esto es antes de la recursividad
            MostrarDigParesRecursivo(NroAux / 10);
            Console.WriteLine("Despues => NroAux : " + NroAux);// esto para ver que pasa despues de la recursividad
        }
    }
    public static void  MostrarDigImparesRecursivo(int N)
    {
        int  NroAux = N;
        if(NroAux == 0)
        {
            return;
        }
        else
        {
            int dig = NroAux % 10;
            if(dig % 2 != 0)
            {
                Console.WriteLine("Dig :" + dig);
            }
            
            MostrarDigImparesRecursivo(NroAux / 10);
        }
    }

    }
}