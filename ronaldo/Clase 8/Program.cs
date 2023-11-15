namespace Clase8
{

    public class Program
    {
        public static void Main(string[] args)
        {
            claseArray A = new claseArray (5) ;
            A.ArrayEnteros [0] = 1 ;
            A.ArrayEnteros [1] = 9 ;
            A.ArrayEnteros [2] = 10 ;
            A.ArrayEnteros [3] = 2 ;
            A.ArrayEnteros [4] =7 ;
            A.MostrarArray();

            //-------------------

            claseArray B = new claseArray (3) ;
            B.ArrayEnteros [0] = 10 ;
            B.ArrayEnteros [1] = 90 ;
            B.ArrayEnteros [2] = 100 ;
            B.MostrarArray();
           // Console.WriteLine("----------------");
            //A.OrdenamientoBurbuja();
            //A.MostrarArray();
            //Console.WriteLine("----------------");
            //A.Intercalar_Uno();
            //A.MostrarArray();
            Console.WriteLine("----------------");
            //A.DeletebyPosition(1);
            //A.MostrarArray();
            //A.DeletebyPosition(3);
            //A.Unirray(B);
            //A.SumarElmentoArray();
            //B.SumarElmentoArray();
            //A.MostrarArray();
            //A.MultiplicarElmentoArray();
            //B.MultiplicarElmentoArray();
            A.ElevarCuadrado();
            A.MostrarArray();
            B.ElevarCuadrado();
            B.MostrarArray();
        }
    }
}
