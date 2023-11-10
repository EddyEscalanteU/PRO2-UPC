//Realizar una clase con el nombre  
//"Mascota", que tenga las siguientes propiedades:(nombre, edad, NombrePropietario, color, categoria)
//escribir los siguientes metodos 
//DarNombre(string nombre)
//AsignarColor(string color)
public class Mascota{
    public string Nombre;
    public int edad;
    public Persona Propietario;
    public string color;
    public string categoria;

    public Mascota()
    {
        Nombre = "sin nombre";
        edad = 0;
        Propietario = new Persona();
        color = "sin color";
        categoria = "sin categoria";
    }
    public void DarNombre(string valor){
        Nombre = valor;
    }
    public void Asignarcolor(string valor){
        color = valor;

    }
    public string Mostrar(){
        return "Mascota: { nombre: " + Nombre + ", " +
        "Edad; " + edad + ", " +
        "Propietario: " + Propietario.Mostrar() + ", " +
        "Color: " + color + ", " +
        "Categoria: " + Categoria + "}";
    }
}