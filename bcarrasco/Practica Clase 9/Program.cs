 namespace MyNamespace{
 
 public class Program{
        public static void Main(string[] args)
        {
            
            ClaseArray A = new ClaseArray(4);
            A.ArrayCadenas[0] = "Ereli";
            A.ArrayCadenas[1] = "Maria";
            A.ArrayCadenas[2] = "Ines";
            A.ArrayCadenas[3] = "Joel";
            A.MostrarArray();
            Console.WriteLine("____________________________________________________")
             ClaseArray B = new ClaseArray(4);
            B.ArrayCadenas[0] = "Douglas";
            B.ArrayCadenas[1] = "Ereli";
            B.ArrayCadenas[2] = "Suarez";
            B.ArrayCadenas[3] = "Maria";
            B.ArrayCadenas[4] = "Joel";
            B.MostrarArray();





            

            char c0 =char.Parse(A.ArrayCadenas[0]);
            char c0 =char.Parse(A.ArrayCadenas[1]);
            char c0 =char.Parse(A.ArrayCadenas[2]);
            char c0 =char.Parse(A.ArrayCadenas[3]);

            Console.WriteLine(c0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine((int)c0);
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c2);
            Console.WriteLine((int)c3);

            char c = 'A';        
            Console:WriteLine((int)c);
            Console:WriteLine((int)65);
            string srt = "A";
            Console.WriteLine(char.Parse(str));
        }
    }
}
