using System.Xml.Serialization;

public class Estudiante

{
    public int ID;
    public string Nombre;
    public string Materia;
    public string Docente;
    public Estudiante(){
        ID = 0;
        Nombre = "sin nombre";
        Materia = "sin materia";
        Docente = "sin nombre";
    }
    public void AsignarCode(int ID)
    {
        ID = 0;
    }
     public string Mostrar(){
        return "ID: { Nombre: " + Nombre + ", " +
        "Materia: " + Materia + ", " +
        "Docente: " + Docente + "}";
     }
   

}
