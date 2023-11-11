﻿namespace ClaseEntero
{
    public class Program{
        public static void Main(string[] args)
        {
            Entero Nro = new Entero(21);
            Nro.N = 243111138;
            Console.WriteLine("N: " + Nro.N);
            //bool res = Nro.EsPar_Mejorado();
            //bool res = Nro.EsMultiploN(2);
            //Console.WriteLine("EsMultiploN: " + res);

            ///Nro.MostrarDigitos();
            Nro.MostrarDigPares();
        }
    }
}
