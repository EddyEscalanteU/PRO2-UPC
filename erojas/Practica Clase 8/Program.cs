namespace Clase8
{
    public class Program{
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(5);
            A.ArrayEnteros[0] = 1;
            A.ArrayEnteros[1] = 9;
            A.ArrayEnteros[2] = 10;
            A.ArrayEnteros[3] = 2;
            A.ArrayEnteros[4] = 7;
            A.MostrarArray();
            //Console.WriteLine("-----------------------");
            //A.OrdenamientoBurbuja();
            //A.MostrarArray();
            //Console.WriteLine("-----------------------");
            //A.Intercalar_Uno();
            //A.MostrarArray();
            Console.WriteLine("-----------------------");
            A.DeleteByPosition(1);
            A.MostrarArray();
            A.DeleteByPosition(3);
            A.MostrarArray();
            
        }
    }
}

