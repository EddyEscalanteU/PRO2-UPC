using System;

namespace HelloWorld
{
  class Program 
  {
    static void Main(string[] args){

        Mascota Laika = new Mascota ();
        Laika.DarNombre("Laika");
        Laika.DarEdad(1);
        Laika.DarNombrePropietario("Alejandra villagomez");
        Laika.AsignarColor("Negro y blanco");
        Laika.AsignarCategoria("Perro");
        

        Console.Write("Nombre: ");
        Console.WriteLine(Laika.Nombre);

        Console.Write("Edad: ");
        Console.WriteLine(Laika.Edad+ " Años");

        Console.Write("Nombre del Propietario: ");
        Console.WriteLine(Laika.NombrePropietario);

        Console.Write("Color: ");
        Console.WriteLine(Laika.Color);

        Console.Write("Categoria: ");
        Console.WriteLine(Laika.Categoria);

        // Mascota myMascota = new Mascota();
        // Console.WriteLine(myMascota.Mostrar);

        Console.ReadKey();

    }
  }
}