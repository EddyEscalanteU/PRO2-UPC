using System;

public class Estudiante
    {
    //Propiedades
    public int Id { get; set; }
    public string NombreCompleto { get; set; }
    public int Carnet { get; set; }
    public string Genero { get; set; }
    public int Edad { get; set; }

    }

    public Estudiant(int id, string name, int CI, string genero, int edad)
    {
        Id = id;
        NombreCompleto = name;
        Carnet = CI;
        Genero = genero;
        Edad = edad;
    }
    /*public void Estudiant(int id, string name, int CI, string genero, int edad)
    {
        Id = id;
        NombreCompleto = name;
        Carnet = CI;
        Genero = genero;
        Edad = edad;
    }*/

// Método para mostrar la información
public void Mostrar()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre Completo: {NombreCompleto}");
        Console.WriteLine($"Carnet: {Carnet}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Edad: {Edad} años");
    }
    

   /*public string Mostrar(){
        return "Estudiante: { Id: " + Id + ", " +
        "NombreCompleto: " + NombreCompleto + ", "+
        "Carnet: " + Carnet + ", "+
        "Genero: " + Genero + ", "+
        "Edad: " + Edad + "}"; 

    }*/
  


}