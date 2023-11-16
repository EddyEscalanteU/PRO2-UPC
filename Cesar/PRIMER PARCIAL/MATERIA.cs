public class Materia
{
    public int id;
    public string nombrecompleto;
    public string abreviatura;
    public int capacidad;

    public Materia()
    {
        id = 0;
        nombrecompleto = "Sin Nombre";
        abreviatura = "Sin Abreviatura";
        capacidad = 0;
    }

    public Materia(int id, string name, string ab, int capacidad)
    {
        // Corregir asignaciones aquí
        this.id = id;
        this.nombrecompleto = name;
        this.abreviatura = ab;
        this.capacidad = capacidad;
    }

    public string Mostrar()
    {
        return "Materia { id: " + id + ", " + "Nombre: " + nombrecompleto + ", " + " Abreviatura: " + abreviatura + ", " +
               "Capacidad: " + capacidad + " }";
    }
}
