//Realizar una clase con el nombre
// "Mascota", que tenga las siguientes propiedades: (Nombre, Edad, NombrePropietario, Color, Catergoria).
//Escribir los siguientes metodos: 
// DarNombre(string nombre)
// AsignarColor(string color)

public class Mascota
{
    public string Nombre;
    public int edad;
    //public string NombrePropietario;
    public Persona propietario;
    public string color;
    public string Catergoria;


    public Mascota()
    {
        Nombre = "sin nombre";
        edad = 0;
        propietario = new Persona();
        color = "sin color";
        Catergoria = "sin categoria";
    }

    public void DarNombre(string valor)
    {
        Nombre = valor;
    }

    public void AsignarColor(string valor)
    {
        color = valor;
    }

    public string Mostrar(){
        return "Mascota: { Nombre: " + Nombre + ", " +
        "Edad: " + edad + ", " +
        "Propietario: " + propietario.Mostrar() + ", " +
        "Color: " + color + ", " +
        "Catergoria: " + Catergoria + "}";
    }

}