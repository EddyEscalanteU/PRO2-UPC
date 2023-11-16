using System;

public class Inscrito
{
    //Propiedades
    public int Id;
    public string Fecha;
    public int IdEstudiante;
    public int IdMateria;

    public Inscrito()

    {
        Id = { get; set; }
        Fecha = { get; set; }
        IdEstudiante = { get; set; }
        IdMateria = { get; set; }
    }

    public Inscrito(int id, string fecha, int IdEstudiant, int materia)
    {
        Id = id;
        Fecha = fecha;
        IdEstudiante = IdEstudiant;
        IdMateria = materia;
        
    }

    // Método para mostrar la información
    public void Mostrar()
    {
        Console.WriteLine($"ID : {Id}");
        Console.WriteLine($"Fecha de inscripción: {Fecha}");
        Console.WriteLine($"Identificación: {IdEstudiante}");
        Console.WriteLine($"Materia de Inscripción: {IdMateria}");
    }

    
}