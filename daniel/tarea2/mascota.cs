//realizar una clase con el nombre
// "mascota", que tenga las siguientes propiedades: (Nombre, Edad, Nombre Propietario, Color, Categoria).
//Escribir los siguientes metodos:
// Dar Nombre(string nombre)
// AsignarColor (string color)

public class mascota
{
    public string nombre;
    public int edad;
    public string NombrePropietario;
    public string color;
    public string categoria;

  
    public mascota()
    {
        nombre = "Sin nombre";
        edad = 0;
        NombrePropietario = "sin nombre";
        color = "sin color";
        categoria = "sin categoria";
    }

    public void DarNombre(string valor)
    {
        nombre = valor;
    }

    public void AsignarColor(string Valor)
    {
        color = Valor;

    }

}