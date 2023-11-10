using System;

namespace HelloWorld
{
  class Program 
  {
    static void Main(string[] args){

        Mascota Firulais = new Mascota ();
        Firulais.DarNombre("Firulais");
        Firulais.DarEdad(3);
        Firulais.DarNombrePropietario("Elias Rojas");
        Firulais.AsignarColor("Negro y Gris");
        Firulais.AsignarCategoria("Perros");
        

        Console.Write("Nombre: ");
        Console.WriteLine(Firulais.Nombre);

        Console.Write("Edad: ");
        Console.WriteLine(Firulais.Edad+ " Años");

        Console.Write("Nombre del Propietario: ");
        Console.WriteLine(Firulais.NombrePropietario);

        Console.Write("Color: ");
        Console.WriteLine(Firulais.Color);

        Console.Write("Categoria: ");
        Console.WriteLine(Firulais.Categoria);

        Console.ReadKey();

    }
  }
}
