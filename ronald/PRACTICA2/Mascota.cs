using System.Drawing;

public class Mascota
{
    public string nombre;
    public int edad; 
    public string nombrePropietario;
    public string color;
    public string categoria;

    //metodo contructor
    public Mascota()
    {
        nombre = "sin nombre" ;
        edad = 0;
        nombrePropietario = "sin nombre"; 
        color = ""; 
        categoria = ""; 
    }

    public void DarNombre(string valor)
    {
        nombre = valor; 
    }

    public void AsignarColor(string valor)
    {
        color = valor;   
    }
    
}