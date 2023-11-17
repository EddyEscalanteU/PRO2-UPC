public class Inscrito
{
    public int id;
    public string fecha;
    public string estudiante;
    public string materia;

    public Inscrito()
    {
        id = 0;
        fecha = "Sin Fecha";
        estudiante = "Sin Nombre";
        materia = "Sin Materia";
    }

    public Inscrito(int id, string dia, string name, string mat)
    {
        // Corregir asignaciones aquí
        this.id = id;
        fecha = dia;
        estudiante = name;
        materia = mat;
    }

    public string Mostrar()
    {
        return "Inscrito { id: " + id + ", " + "Fecha: " + fecha + ", " + " Estudiante: " + estudiante + ", " +
               "Materia: " + materia + " }";
    }
}
