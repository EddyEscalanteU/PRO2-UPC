public class Estudiante{
    private int Id;
    private string Fecha;
    private int IdEstudiante;
    private int Materia;
    public Estudiante(){
        Id = 0;
        Fecha = "15/11/2023";
        IdEstudiante = 0;
        Materia = 0;
    }
    public Estudiante(int ci, string fecha, int myMateria, int IdEstudiantee){    
        Id = ci;
        Fecha = fecha;
        IdEstudiante = IdEstudiantee;
        Materia = myMateria;
    }
    public string Mostrar(){
        return "Estudiante { Id: " + Id + ", " +
        "Fecha: " + Fecha + ", " +
        "Materia: " + Materia + " " +"IdEstudiante: " + IdEstudiante +" }";
    }
}