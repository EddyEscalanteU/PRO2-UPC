namespace Clase8
{
    public class Program{
        public static void Main(string[]args)
        {
            CLaseArray A = new CLaseArray(5);
            A.ArrayEnteros[1] = 1;
            A.ArrayEnteros[2] = 9;
            A.ArrayEnteros[3] = 10;
            A.ArrayEnteros[4] = 2;
            A.ArrayEnteros[5] = 7;

            //ArrayEnteros [5]
            A.MostrarArray();
            Console.WriteLine("-----------");
            A.OrdenamientoBurbuja();
            A.MostrarArray();
        }
    }
}