﻿namespace Programacion2
{
    public class Matrices
    {
        public static void  Main(string[] args)
        {
            MatrizEnteros Matriz = new MatrizEnteros(4,4);
            //M.defaultValue = 7;
            Matriz.CargarMatrizDeafault();
            Matriz.MostraMatriz();

            Console.WriteLine("---------------------------");

            //Estas son 2 formas de llamar a la matriz//Estas son 2 formas de llamar a la matriz
            //Matriz.M[2,1] = 5 ;       // opcion 1
            //Matriz.Insertar(2,1,5);  // opcion 2
            Matriz.M[2,1] = 5 ;
            Matriz.M[3,0]=7;
            Matriz.M[1,3]=3;
            Matriz.M[0,2]=2;
            Matriz.M[2,2]=5;
            Matriz.M[1,2]=9;
            Matriz.M[3,1]=2;
            Matriz.M[1,0]=3;
            Matriz.M[2,0]=5;
            Matriz.M[1,1]=5;
            Matriz.M[0,3]=1;
            Matriz.M[0,1]=3;
            Matriz.M[3,2]=3;
            Matriz.M[3,3]=5;
            Matriz.Insertar(2,3,6);
            Matriz.Insertar(0,0,1);
            Matriz.MostraMatriz(); 
            
            Console.WriteLine("---------------------------");
            
            Matriz.LlenarMatriz_v1();
            Matriz.MostraMatriz(); 

            Console.WriteLine("---------------------------");

            Matriz.LlenarMatriz_v2();
            Matriz.MostraMatriz(); 

            Console.WriteLine("---------------------------");
// aca seria  como la version 2 pero este cuenta del 1 dependiendo la matriz pero comienza al reves 
            Matriz.LlenarMatriz_v3();
            Matriz.MostraMatriz();

            Console.WriteLine("---------------------------");

            Matriz.LlenarMatriz_v4();
            Matriz.MostraMatriz();

            Console.WriteLine("---------------------------");

            Matriz.LlenarMatriz_v5();
            Matriz.MostraMatriz();

            Console.WriteLine("---------------------------");
        }

    }
}