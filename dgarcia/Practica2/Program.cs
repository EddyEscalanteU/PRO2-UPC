namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            {
                Mascota mascota1 = new Mascota();
                Console.WriteLine(mascota1.Nombre);
                mascota1.DarNombre("pacho");
                Console.WriteLine(mascota1.Nombre);
            }
        }
    }
}