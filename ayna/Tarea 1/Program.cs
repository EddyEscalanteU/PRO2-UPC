namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int resp = CalcularAreaCuadrado(10);
            Console.WriteLine(resp);
        }
        
        static int CalcularAreaCuadrado(int L){
            int resultado = L*L;
            return resultado;
        }

    }
}