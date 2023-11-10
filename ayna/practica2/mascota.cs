//Realizar una clase con el nombre 
// "Mascota", que tenga las siguientes propiedades; (Nombre). Edad,MombrePropietario, color, Categoria).
// Escribir los siguientes metodos:
// DarNombre(String nombre)
// Asignar (string color)
 
 using System.Drawing;
 public class Mascota
 {
    // propiedades
    public string nombre;
    public int edad;
    public string NombrePropietario;
    public string color;
    public string categoria;

    // Constructor
    public Mascota(){
        nombre = ""sin nombre"";
        edad = 0;
        NombrePropietario = "sin nombre"
        color = "sin color";
        categoria = "sin categoria"  
    }
    public void DarNombre(string valor)
    {
        nombre = valor;
    }
    public void AsignarColor(string valor){
        color =  valor;
    }
        
    public{
        
    }




 }