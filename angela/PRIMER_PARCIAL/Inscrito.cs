public class Inscrito{

    private string Fecha;
    private int Estudiantes;
    private int Materia;
    public Inscrito(){
         
         Fecha = "Sin fecha";
         Estudiantes = 0;
         Materia = 0;

        }
    public Inscrito(string date, int studen, int  youMateria){

        Fecha = date;
        Estudiantes = 0;
        Materia = youMateria;
        
    }
    public string Mostrar(){
        return "Inscrito { Fecha: " + Fecha + ", " +
           " Estudiante: " + Estudiantes + ", " +
            " Materia: " + Materia + " }";
    }

}