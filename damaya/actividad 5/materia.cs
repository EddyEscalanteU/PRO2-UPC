public class Materia
{
    public string Grupo;
    public string materia;
    public string Docente;
    public int Periodo;
    public int Hora;
    public Materia()
    {
        Grupo = "Sin nombre";
        materia = "Sin nombre";
        Docente = "Sin nombre";
        Periodo = 0;
        Hora = 0;
    }
    public Materia(string grup, string asignatura, string teacher, int period, int hour){
        Grupo = grup;
        materia = asignatura;
        Docente = teacher;
        Periodo = period;
        Hora = hour;
    }
    public string Mostrar(){
        return "Materia { Grupo: " + Grupo + ", " +
        "materia: " + materia + ", " +
        "Docente: " + Docente + ", " +
        "periodo: " + Periodo + ", " +
        "hora, " + Hora + "}";
    }
}
