namespace Practica2{
    class Program{
        public static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            Console.WriteLine(mascota1.Nombre);
            mascota1.DarNombre("firulais");
            Console.WriteLine(mascota1.Nombre);
        }
    }
}
