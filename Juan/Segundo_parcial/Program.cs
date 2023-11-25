public class Program
    {
        public static void Main(string[] args)
        {
           //long f = Factorial(64);
           //Console.WriteLine(f);
           MostrarDigImparesRecursivo(12345678);
        }  


public static void MostrarDigImparesRecursivo(int N)
{
    if (N != 0)
    {
        int dig = N % 10;
        if (dig % 2 != 0)
        {
            Console.WriteLine("Dig: " + dig);
        }
        MostrarDigImparesRecursivo(N / 10);
    }
}
}