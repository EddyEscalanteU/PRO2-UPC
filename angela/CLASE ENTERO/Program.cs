﻿namespace ClaseEntero
{
    class Program
    {
        static void Main(string[] args)
        {
            Entero Nro = new Entero(14);
            Nro.N = 7;
            bool res = Nro.EsPar();
            Console.WriteLine(res);
        }
    }
}
