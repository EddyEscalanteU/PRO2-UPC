namespace MyNamespace
{

    public class Program
    {
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(4);
            
            A.ArrayCadenas[0] = "Ereli";
            A.ArrayCadenas[1] = "Maria";
            A.ArrayCadenas[2] = "Ines";
            A.ArrayCadenas[3] = "Joel";
            A.MostrarArray();

            Console.WriteLine("-------------");
            ClaseArray B = new ClaseArray(5);
            B.ArrayCadenas[0] = "Douglas";
            B.ArrayCadenas[1] = "Ereli";
            B.ArrayCadenas[2] = "Suarez";
            B.ArrayCadenas[3] = "a";
            B.MostrarArray();