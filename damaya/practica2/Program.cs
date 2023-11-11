namespace Practica2
{
    class Program{
       public static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            Console.WriteLine(mascota1.Mostrar);
            mascota1.Mostrar("rufus");
            Console.WriteLine(mascota1.Mostrar);

            Persona variable_juan = new Persona();
            Console.WriteLine(variable_juan.Mostrar());
            Persona pedro = new Persona(123, "pedro", 10);
            Console.WriteLine(pedro.Mostrar());
        }
    }
}