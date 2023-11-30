public class Materia
{
    public string Grupo;
    public string Nombremateria;
    public string Docente;
    public int Periodo;
    public string Hora;

    public Materia()
    {
        Grupo = "Turno Noche"; 
        Nombremateria = "Program";
        Docente = "Eddy";
        Periodo = 10;
        Hora = "19:00 PM";
    }

    public Materia(string grup, string asignatura, string teacher, int period, string hour){
        Grupo = grup;
        Nombremateria = asignatura;
        Docente = teacher;
        Periodo = period;
        Hora = hour;
    }

    public string Mostrar(){
        return "Materia { Grupo: " + Grupo + ", " +
        "Materia: " + Nombremateria + ", " +
        "Docente: " + Docente + ", " +
        "Periodo: " + Periodo + ", " +
        "Hora, " + Hora + "}";
    }
}