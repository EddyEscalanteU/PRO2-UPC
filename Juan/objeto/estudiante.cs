public class Estudiante
{
    // Propiedades del estudiante
    public string nombre;
    public int edad;
    public int nota;

    // Constructor por defecto
    public Estudiante()
    {
        nombre = "Sin Nombre";
        edad = 100;
        nota = 100;
    }

    // Método para establecer el nombre del estudiante
    public void SetNombre(string valor)
    {
        nombre = valor;
    }

    // Método para restar edad al estudiante
    public void RestarEdad(int valor)
    {
        edad -= valor; // Utilizar la forma abreviada de resta
    }

    // Método para aplazar al estudiante (fijar nota en 49)
    public void AplazarEstudiante()
    {
        nota = 49;
    }

    // Método para agregar puntos extra a la nota del estudiante
    public void AgregarPuntosExtra(int puntos)
    {
        nota += puntos; // Utilizar la forma abreviada de suma
    }

    // Método para determinar si el estudiante aprobó o reprobó
    public string AprobadoReprobado()
    {
        if (nota >= 51)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }
}
