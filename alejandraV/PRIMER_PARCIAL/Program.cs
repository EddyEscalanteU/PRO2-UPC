namespace Examen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(5);
            A.ArrayEnteros[0] = 15;
            A.ArrayEnteros[1] = 37;
            A.ArrayEnteros[2] = 1;
            A.ArrayEnteros[3] = 3;
            A.ArrayEnteros[4] = 7;

            A.SumaArrayEnteros();
        }
    }
}