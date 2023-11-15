﻿namespace MyNamespace{

    public class Program{
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(4);
            A.ArrayCadenas[0] = "Ho";
            A.ArrayCadenas[1] = "la ";
            A.ArrayCadenas[2] = "Mun";
            A.ArrayCadenas[3] = "do";
            A.MostrarArray();

            char c = 'A';
            Console.WriteLine((int)c);
            Console.WriteLine((char)65);
            string str = "A";
            Console.WriteLine(char.Parse(str));


        }
    }
}

