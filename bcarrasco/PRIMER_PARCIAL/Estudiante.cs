using System;

public class Estudiante
{
    
    public int Id { get; set; }
    public string NombreCompleto { get; set; }
    public int Carnet { get; set; }
    public string Genero { get; set; }
    public int Edad { get; set; }

    // Constructor
    public Estudiante(int id, string nombre, int carnet, string genero, int edad)
    {
        Id = id;
        NombreCompleto = nombre;
        Carnet = carnet;
        Genero = genero;
        Edad = edad;
    }

    // Método para mostrar la información del estudiante
    public void Mostrar()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre Completo: {NombreCompleto}");
        Console.WriteLine($"Carnet: {Carnet}");
        Console.WriteLine($"Género: {Genero}");
        Console.WriteLine($"Edad: {Edad} años");
    }
}

