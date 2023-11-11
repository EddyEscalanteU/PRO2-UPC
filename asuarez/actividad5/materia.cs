public class Materia
{
    public string Grupo;
    public string Nombremateria;
    public string Docente;
    public int Periodo;
    public int Hora;
    public Materia()
    {
        Grupo = "Sin nombre";
        Nombremateria = "Programacion 2";
        Docente = "Eddy escalante";
        Periodo = 0;
        Hora = 0;
    }
    public Materia(string grup, string asignatura, string teacher, int period, int hour){
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
        "periodo: " + Periodo + ", " +
        "hora, " + Hora + "}";
    }
}