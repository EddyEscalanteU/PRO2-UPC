public class Materia
{
    public string Grupo;
    public string materia;
    public string Docente;
    public int periodo;
    public int hora;
    public Materia()
    {
        Grupo = "Sin nombre";
        materia = "Sin nombre";
        Docente = "Sin nombre";
        periodo = 0;
        hora = 0;
    }
    public Materia(string grup, string asignatura, string teacher, int period, int hour){
        Grupo = grup;
        materia = asignatura;
        Docente = teacher;
        periodo = period;
        hora = hour;
    }
    public string Mostrar(){
        return "Materia { Grupo: " + Grupo + ", " +
        "materia: " + materia + ", " +
        "Docente: " + Docente + ", " +
        "periodo: " + periodo + ", " +
        "hora, " + hora + "}";
    }
}
