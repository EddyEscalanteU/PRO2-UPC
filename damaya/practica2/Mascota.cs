//Realizar una clase con el nombre  
//"Mascota", que tenga las siguientes propiedades:(nombre, edad, NombrePropietario, color, categoria)
//escribir los siguientes metodos 
//DarNombre(string nombre)
//AsignarColor(string color)
public class Mascota{
    public string Nombre;
    public int edad;
    public string NombrePropietario;
    public string color;
    public string categoria;
    
    public Mascota()
    {
        Nombre = "sin nombre";
        edad = 0;
        NombrePropietario = "sin nombre";
        color = "sin color";
        categoria = "sin categoria";
    }
    public void DarNombre(string valor){
        Nombre = valor;
    }
    public void Asignarcolor(string valor){
        color = valor;

    }
}