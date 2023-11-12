namespace ClasdeEntero
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Entero Nro = new Entero(21);
            Nro.N = 2541;
            Console.WriteLine("N: " + Nro.N);
           //bool res = Nro.EsPar_Mejorado();
           //bool res = Nro.EsMultiploN(5);
           //Console.WriteLine(res);
           // Console.WriteLine("EsMultiploN: " + res);

            Nro.MostrarDigitos();

        }
    }


    }
