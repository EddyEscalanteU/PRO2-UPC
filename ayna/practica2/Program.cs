namespace Prantica2
{
    class Programa
    {
        static void Main(string [] args)
        {
            Mascota mascota1 = new mascota();
            console.WriteLine(mascota1.Nombre);
            mascota1.DarNombre("sin nombre");
            console.WriteLine(mascota1.Nombre);

        }
    }
}