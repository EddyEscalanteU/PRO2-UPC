using System.ComponentModel;

namespace Programacion2
{
    public class Matrices
    {
        public static void  Main(string[] args)
        {

            MatrizCadenas MC = new MatrizCadenas(8,8);
            MC.CargarMatrizDeafault();
            for (int i = 0; i < 4; i++)
            {
                int x = 0;
                //serie x
                if(i < 2)
                {
                    x = 1;
                }
                else
                {
                    x = 3;
                }

                //serie y
                int y = 0;

                if(i == 0 || i == 3)
                {
                    y = 0;
                }
                else
                {
                    y = 2;
                }
            
            MC.Insertar(x,y,"BLANCO");
                
            }
            for (int i = 0; i < 4; i++)
            {
                int x = 0;
                //serie x
                if(i < 2)
                {
                    x = 5;
                }
                else
                {
                    x = 7;
                }

                //serie y
                int y = 0;

                if(i == 0 || i == 3)
                {
                    y = 0;
                }
                else
                {
                    y = 2;
                }
            
            MC.Insertar(x,y,"BLANCO");
                
            }



            MC.Insertar(0,1,"BLANCO");
            MC.Insertar(2,1,"BLANCO");
            MC.Insertar(4,1,"BLANCO");
            MC.Insertar(6,1,"BLANCO");


            for (int i = 0; i < 4; i++)
            {
                int x = 0;
                //serie x
                if(i < 2)
                {
                    x = 0;
                }
                else
                {
                    x = 2;
                }

                //serie y
                int y = 0;

                if(i == 0 || i == 3)
                {
                    y = 5;
                }
                else
                {
                    y = 7;
                }
            
            MC.Insertar(x,y,"ROJO");
                
            }
            for (int i = 0; i < 4; i++)
            {
                int x = 0;
                //serie x
                if(i < 2)
                {
                    x = 4;
                }
                else
                {
                    x = 6;
                }

                //serie y
                int y = 0;

                if(i == 0 || i == 3)
                {
                    y = 5;
                }
                else
                {
                    y = 7;
                }
            
            MC.Insertar(x,y,"ROJO");
                
            }



            MC.Insertar(1,6,"ROJO");
            MC.Insertar(3,6,"ROJO");
            MC.Insertar(5,6,"ROJO");
            MC.Insertar(7,6,"ROJO");

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
