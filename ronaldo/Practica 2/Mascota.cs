using System.ComponentModel;

public class Mascota
{
    //Las Propiedades
    public string nombre;

    public int edad;

    public string NombredelPropietario;

    public string color;

    public string categoria;

    public Mascota()
    {
        nombre = "";
        edad = 0;
        NombredelPropietario = "Sin Nombre";
        color = "Sin Color" ;
        categoria = "Sin Categoria";

    }
    public void Darnombre(string valor)
    {
        nombre = valor ;
    }

    public void AsignarColor(string valor)
    {
        color = valor ;
    }

    public void AsiganarCategoria(string valor)
    {
        categoria = valor ;
    }

    public void AsginarEdad(int valor)
    {
        edad = 01;
    }

    public void AsiganarNombredelPropietario(string valor)
    {
        NombredelPropietario = valor ;
    }

}
