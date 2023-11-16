namespace Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            Console.WriteLine(mascota1.nombre);
            mascota1.Darnombre("Kiara");
            mascota1.AsginarEdad(01);
            mascota1.AsignarColor("Blanco");
            mascota1.AsiganarCategoria("BullTerrier");
            mascota1.AsiganarNombredelPropietario("Ronaldo Zegarrundo Gutierrez");

            Console.WriteLine("NOMBRE:");
            Console.WriteLine(mascota1.nombre);
            Console.WriteLine("EDAD:");
            Console.WriteLine(mascota1.edad);
            Console.WriteLine("COLOR:");
            Console.WriteLine(mascota1.color);
            Console.WriteLine("CATEGORIA:");
            Console.WriteLine(mascota1.categoria);
            Console.WriteLine("NOMBRE DEL PROPIETARIO");
            Console.WriteLine(mascota1.NombredelPropietario);

            // metodo tostring(mostrar) : ver todo los datos en forma horizontal
            Persona pedro = new Persona(123,"Pedro",10);
            Console.WriteLine(pedro.Mostrar());
            
        }
    }
}
