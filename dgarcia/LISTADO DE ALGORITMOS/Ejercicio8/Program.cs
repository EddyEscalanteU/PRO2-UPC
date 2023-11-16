namespace MyNamespace{

    public class Program{
        public static void Main(string[] args)
        {
            ClaseArrayEquivalencias A = new ClaseArrayEquivalencias(4);           
            A.ArrayCadenas[0] = "A";
            A.ArrayCadenas[1] = "k";
            A.ArrayCadenas[2] = "e";
            A.ArrayCadenas[3] = "G";
            A.MostrarArray();
            Console.WriteLine("-----------------");

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
        }
    }
}