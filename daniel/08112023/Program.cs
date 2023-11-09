namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sumaDosNumeros");
            int x = 10;
            int y = 20;
            int respuesta = sumaDosNumeros (x, y);
            Console.WriteLine(respuesta);
        }
        static int sumaDosNumeros(int a, int b){
            return a + b;
        }

        
    }
}