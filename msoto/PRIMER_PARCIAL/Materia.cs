using System;

public class Materia
{
    //Propiedades
    public int Id;
    public string Nombre;
    public string Abreviatura;
    public int Capacidad;

    public Materia()
    {
        Id = { get; set; }
        Nombre = { get; set; }
        Abreviatura = { get; set; }
        Capacidad = { get; set; }
    }
    public Materia(int id, string nombre, string abreviatura, int capacidad)
    {
        Id = id;
        Nombre = nombre;
        Abreviatura = abreviatura;
        Capacidad = capacidad;
        
    }

    // Método para mostrar la información
    public void Mostrar()
    {
        Console.WriteLine($"ID : {Id}");
        Console.WriteLine($"Fecha de inicio de materia: {Fecha}");
        Console.WriteLine($"Identificación del estudiante: {IdEstudiante}");
        Console.WriteLine($"ID de Materia: {IdMateria}");
    }

    
}