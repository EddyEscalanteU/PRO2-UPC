namespace Program
{
    public class Program
    {
       public static void Main(string[] args)
        {
            ArrayEnt A = new ArrayEnt(4);
            A.ArrayEnteros[0] = 3;
            A.ArrayEnteros[1] = 3;
            A.ArrayEnteros[2] = 2;
            A.ArrayEnteros[3] = 4;
            A.MostrarArray();
            Console.WriteLine("-------------------");
            ArrayEnt B = new ArrayEnt(3);
            B.ArrayEnteros[0] = 7;
            B.ArrayEnteros[1] = 1;
            B.ArrayEnteros[2] = 3;
            B.MostrarArray();


            A.MostraMaxMinArrayEnteros();
            Console.WriteLine("-------------------");

            Console.WriteLine("Mostrar la suma de los arrays: ");
            int sum = A.SumaArrayEnteros();
            Console.WriteLine(sum);
            Console.WriteLine("-------------------");  

            Console.WriteLine("Mostrar el fibonacci: ");
            int n = A.CalcularFibonacci(2);
            Console.WriteLine(n);
            Console.WriteLine("-------------------");  


            A.UnirArray(B);
            Console.WriteLine("-------------------");
            A.Intercalar();
            Console.WriteLine("-------------------");
            A.OrdenarArrayAcendente();
            Console.WriteLine("-------------------");
            A.OrdenarArraydesendente();


        }
    }
}       