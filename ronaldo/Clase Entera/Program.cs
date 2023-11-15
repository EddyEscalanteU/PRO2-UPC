namespace ClaseEntero;

class Program
{
    static void Main(string[] args)
    {
        Entero Nro = new Entero (21);
        Nro.N = 243111138 ;
        Console.WriteLine("N:" + Nro.N);
        //bool res = Nro.EsPar_Mejorado();
        // bool res = Nro.EsMultiploN(7);
        //  Console.WriteLine("EsMutiploN: " + res );

        //Nro.MostrarDigitos();
        Nro.MostrarDigPares();
    }
}