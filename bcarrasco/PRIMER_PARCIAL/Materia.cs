using System;

public class Materia
{
    // Propiedades
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Abreviatura { get; set; }
    public int CapacidadEstudiantes { get; set; }

    // Constructor
    public Materia(int id, string nombre, string abreviatura, int capacidadEstudiantes)
    {
        Id = id;
        Nombre = nombre;
        Abreviatura = abreviatura;
        CapacidadEstudiantes = capacidadEstudiantes;
    }

    // Método para mostrar la información de la materia
    public void Mostrar()
    {
        Console.WriteLine($"ID de la Materia: {Id}");
        Console.WriteLine($"Nombre de la Materia: {Nombre}");
        Console.WriteLine($"Abreviatura: {Abreviatura}");
        Console.WriteLine($"Capacidad de Estudiantes: {CapacidadEstudiantes}");
    }
}
