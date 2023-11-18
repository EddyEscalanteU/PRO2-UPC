public class Materia
{
    public int id; 
    public string Nombre;
    public string Abreviatura;
    public int Capacidad; 


    public Materia()
    {
        id = 0;
        Nombre = "Sin nombre";
        Abreviatura = "Sin abreviatura";
        Capacidad = 0;
    }

    public string Mostrar()
    {
        return "Materia{  " + "Nombre: " + Nombre + ",  " + "Abreviatura: " + Abreviatura + 
        ",  " + "Capacidad: " + Capacidad + " }" ; 

    }

}