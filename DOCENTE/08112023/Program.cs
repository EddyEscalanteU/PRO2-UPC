﻿namespace HelloWorld
{
    //new class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sumaDosNumeros");
            int x = 20;
            int y = 21;
            int respuesta = sumaDosNumeros(x, y);
            Console.WriteLine(respuesta);

            int respuesta2 = multiplicarDosNumeros(x, y);
            Console.WriteLine(respuesta2);
        }

        static int sumaDosNumeros(int a, int b){
            return a + b;
        }

        static int multiplicarDosNumeros(int a, int b){
            return a * b;
        }
    }
}