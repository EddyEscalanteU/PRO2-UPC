// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace ClaseEntero
{
    public class Program {
        public static void Main(string[]args)
        {
            Entero Nro = new Entero(15);
            Nro.N = 7
            bool res = Nro.EsPar_Mejorado();
            Console.WriteLine(res);
             //bool res = Nro.EsPar_Mejorado();
            //bool res = Nro.EsMultiploN(2);
            //Console.WriteLine("EsMultiploN: " + res);


            //Nro.MostrarDigitos();
            //Nro.MostrarDigPares();
            
            
            Cadena C = new Cadena("Console.WriteLine");
            Console.WriteLine("Cadena: " + C.Cad);

            //char caracter = C.ObtenerCaracter(3);
            //Console.WriteLine("Char: " + caracter);

            C.MostrarCaracteres();

        }
    }

    
}