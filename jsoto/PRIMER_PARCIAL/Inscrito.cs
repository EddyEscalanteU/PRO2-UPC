using System.Text;

public class Inscrito
{
    public int  id; 
    public string Fecha;
    public int IdEstudiante;
    public int IdMateria; 


    public Inscrito()
    {
        id = 0;
        Fecha = "Sin fecha";
        IdEstudiante = 0;
        IdMateria = 0;
    }
     
     public string Mostrar()
     {
        return "Inscritos{ Id: " + id + ",  " + "Fecha: " + Fecha + 
        ",  " + "Id Estudiante: " + IdEstudiante + ",  " + "Id Materia: " + 
        IdMateria + " }";


     }

}