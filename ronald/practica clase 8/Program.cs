namespace Clase8
{
    public class Program{
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(4);
            A.ArrayEnteros[0] = 85;
            A.ArrayEnteros[1] = 74;
            A.ArrayEnteros[2] = 544;
            A.ArrayEnteros[3] = 12;
            //A.ArrayEnteros[4] = 111; //Error
            A.MostrarArray();
            A.OrdenamientoBurbuja();
            Console.WriteLine("------------------------");
            A.MostrarArray();


        }
    }
}