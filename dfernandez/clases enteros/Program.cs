namespace ClaseEntero
{

    public class Program{

        public static void Main(string[] ArraySegment)
        {
            Enteros Nro = new Enteros(14);
            Nro.N = 7;
            bool res = Nro.EsPar();
            Console.WriteLine(res);

        }
    }
}

