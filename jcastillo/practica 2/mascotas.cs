//Realizar una clase con el nombre
//"Mascotas", que tenga las siguientes propiedades: (Nombre, Edad, Nombrepropietario, color, Categoria). */
//Escribir los siguientes metodos:
//Darnombre (String nombre)
//asignarcolor (String color)

public class Mascota
{
    public String nombre;
    public int edad;
    public String Nombrepropietario;
    public String color;
    public String Categoria;

    public Mascota()
    {
        Nombre = "sin nombre";
        Edad = 0;
        Propietario =new persona();
        Color = "sin color";
        Categoria = "sin categoria";
        
    }    

    public void DarNombre(String valor)
    {      
        nombre = valor;
    }

    public void Asignarcolor(String valor)
    {
        color = valor;
    }

    public String Mostrar()
    {
        return " mascota { Nombre: " + Nombre + ", "+
        "Edad: " + edad + ", " +
        "Nombre Propietario: " + propietario.Mostrar() + ", " +
        "Color: " + color + ", " +
        "Categoria: " + categoria + ", " + " } "


    }

}       
        
