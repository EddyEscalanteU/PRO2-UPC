﻿namespace MyNamespace{

    public class Program{
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(4);
          
            A.ArrayCadenas[0] = "Ereli";
            A.ArrayCadenas[1] = "Maria";
            A.ArrayCadenas[2] = "Ines";
            A.ArrayCadenas[3] = "Joel";
            A.MostrarArray();
             Console.WriteLine("---------------------------");

            ClaseArray B = new ClaseArray(5);
          
            A.ArrayCadenas[0] = "Douglas";
            A.ArrayCadenas[1] = "Ereli";
            A.ArrayCadenas[2] = "Suarez";
            A.ArrayCadenas[3] = "Maria";
            A.ArrayCadenas[3] = "Joel";
            A.MostrarArray();


            
            
            /*
            char c0 = char.Parse(A.ArrayCadenas[0]);
            char c1 = char.Parse(A.ArrayCadenas[1]);
            char c2 = char.Parse(A.ArrayCadenas[2]);
            char c3 = char.Parse(A.ArrayCadenas[3]);

            Console.WriteLine(c0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine((int)c0);
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c2);
            Console.WriteLine((int)c3);
            */

            /*
            char c = 'A';//Crear un caracter
            Console.WriteLine((int)c);//char to int
            Console.WriteLine((char)65);//int to char
            string str = "A";//Crear un string con solo una letra
            Console.WriteLine(char.Parse(str));//string to char
            */

            A.GenerarAbcdarioMAYUS();
        }
    }
}