﻿namespace Segundo_Parcial{
    
    class Program
    {

        //Convertir el siguiente algoritmo interativo a su equivalente de manera recursiva

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
        // ejercicio 4
    }