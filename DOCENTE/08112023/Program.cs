namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sumaDosNumeros");
            int x = 20;
            int y = 21;
            int respuesta = sumaDosNumeros(x, y);
            Console.WriteLine(respuesta);
        }
        //suma de dos numeros
        
        static int sumaDosNumeros(int a, int b){
            return a + b;
        }
    }
}