﻿namespace MyNamespace{

    public class Program{
        public static void Main (String[] args){
            ClaseArray A = new ClaseArray(4);
            A.ArrayCadena[0] = "Ereli";
            
            A.ArrayCadena[1] = "Maria";
            A.ArrayCadena[2] = "Ines";
            A.ArrayCadena[3] = "Joel";
            A.MostrarArray();
            Console.WriteLine("...............");
            ClaseArray B = new


            char c0 = char.Parse(A.ArrayCadena[0]);
            char c1 = char.Parse(A.ArrayCadena[1]);
            char c2 = char.Parse(A.ArrayCadena[2]);
            char c3 = char.Parse(A.ArrayCadena[3]);

            Console.WriteLine(c0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine((int)c0);
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c2);
            Console.WriteLine((int)c3);

            
            /*char c = 'A';//Crear un caracter
            Console.WriteLine((int)c);//
            Console.WriteLine((char)65);

            string str = "A";
            Console.WriteLine(char.Parse(str));*/
            
        }
    }
}