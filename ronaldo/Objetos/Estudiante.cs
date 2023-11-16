public class Estudiante
{
    //Las Propiedades
    // el public espara que podamos ver
    public string nombre;

    public int edad;

    public int nota;

    // El Constructor (Procedimiento por defecto)

    public Estudiante()
    {
        nombre = "Sin Nombre" ;
        edad = 100 ;
        nota = 100;
    }

    public void SetNombre(string valor)
    {
        nombre = valor ;
    }

    public void RestarEdad(int valor)
    {
        edad = edad - valor ;
    }
    // aqui pusimos 49 es el que restaria  ala nota de 100
    public void AplazarEsudiante(int valord )
    {
        nota = 49;
    }

    public void AgregarPuntosExtras(int puntos)
    {
        nota = nota + puntos ;
    }
        // Aca vimos o creamos un metodo  para ver si aprobo o no
    public string AprobadoReprobado()
    {
        if(nota >= 51)
        {
            return"Aprobado";
        }

        else 
        {
            return"Reprobado";
        }
    }

}