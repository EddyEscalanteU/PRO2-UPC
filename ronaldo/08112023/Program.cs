namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sumaDosnumeros");
            int x = 21;
            int y = 20;
            int respuesta = sumaDosNumeros(  x,  y);
            Console.WriteLine(respuesta);

            int respuesta2 = multiplicarDosNumeros(  x,  y);
            Console.WriteLine(respuesta2);
        }
        static int sumaDosNumeros(int a,int b){
            return a + b;
        }
        static int multiplicarDosNumeros(int a,int b){
            return a * b;
        }
    }
}