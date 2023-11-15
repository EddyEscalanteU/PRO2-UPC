namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(4);
            A.ArrayCadenas[0] = "Ho";
            A.ArrayCadenas[1] = "la";
            A.ArrayCadenas[2] = "Mun";
            A.ArrayCadenas[3] = "do";
           A.MostararArray();

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


           char c = 'A'; //crear un caracter
           Console.WriteLine((int)c); //char to int
           Console.WriteLine((char)65); // int to char 
           string str = "A"; // crear un string con una sola letra 
           Console.WriteLine(char.Parse(str)); //string to char 



        }
    }
}