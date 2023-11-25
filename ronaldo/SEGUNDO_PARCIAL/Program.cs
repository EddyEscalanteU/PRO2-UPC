using System.ComponentModel;

namespace Programacion2
{
    public class Matrices
    {
        public static void  Main(string[] args)
        {

            MatrizCadenas MC = new MatrizCadenas(8,8);
            MC.CargarMatrizDeafault();

            MC.Insertar(1,0,"BLANCO");
            MC.Insertar(3,0,"BLANCO");
            MC.Insertar(5,0,"BLANCO");
            MC.Insertar(7,0,"BLANCO");
            MC.Insertar(0,1,"BLANCO");
            MC.Insertar(2,1,"BLANCO");
            MC.Insertar(4,1,"BLANCO");
            MC.Insertar(6,1,"BLANCO");
            MC.Insertar(1,2,"BLANCO");
            MC.Insertar(3,2,"BLANCO");
            MC.Insertar(5,2,"BLANCO");
            MC.Insertar(7,2,"BLANCO");


            MC.Insertar(0,5,"ROJO");
            MC.Insertar(2,5,"ROJO");
            MC.Insertar(4,5,"ROJO");
            MC.Insertar(6,5,"ROJO");
            MC.Insertar(1,6,"ROJO");
            MC.Insertar(3,6,"ROJO");
            MC.Insertar(5,6,"ROJO");
            MC.Insertar(7,6,"ROJO");
            MC.Insertar(0,7,"ROJO");
            MC.Insertar(2,7,"ROJO");
            MC.Insertar(4,7,"ROJO");
            MC.Insertar(6,7,"ROJO");
            Console.WriteLine("-----------------------------------------------------------------------------");
            MC.MostraMatriz();

            Console.WriteLine("-----------------------------------------------------------------------------");
            MostrarDigImparesIterativo(1151814);
            Console.WriteLine("-------------------------");
            MostrarDigImparesRecursivo(1151814);
            Console.WriteLine("-------------------------");
            
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
            
            Console.WriteLine("Fin de la Recursion");
                return 1;
            }
        else
            {
            
            long fact = n * Factorial( n - 1);
            Console.WriteLine("Llamado a la recusion"+ fact);
            return fact;
            
            }
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
            
            Console.WriteLine("Antes => NroAux : " + NroAux); 
            MostrarDigImparesRecursivo(NroAux / 10);
            Console.WriteLine("Despues => NroAux : " + NroAux);
            }
        }
    }
}
