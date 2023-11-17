using System;

public class Inscrito
{
    // Propiedades
    public int Id { get; set; }
    public string Fecha { get; set; }
    public int IdEstudiante { get; set; }
    public int IdMateria { get; set; }

    // Constructor
    public Inscrito(int id, string fecha, int idEstudiante, int idMateria)
    {
        Id = id;
        Fecha = fecha;
        IdEstudiante = idEstudiante;
        IdMateria = idMateria;
    }

    // Método para mostrar la información del inscrito
    public void Mostrar()
    {
        Console.WriteLine($"ID del Inscrito: {Id}");
        Console.WriteLine($"Fecha de Inscripción: {Fecha}");
        Console.WriteLine($"ID del Estudiante: {IdEstudiante}");
        Console.WriteLine($"ID de la Materia: {IdMateria}");
    }
}


