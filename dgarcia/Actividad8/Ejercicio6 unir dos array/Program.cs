namespace Actividad8
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
            //--------------------------
            ClaseArray B = new ClaseArray(3);
            B.ArrayEnteros[0] = 10;
            B.ArrayEnteros[1] = 90;
            B.ArrayEnteros[2] = 100;
            B.MostrarArray();

            Console.WriteLine("-----------------------");
            A.UnirArray(B);
            A.MostrarArray();
        }
    }
}