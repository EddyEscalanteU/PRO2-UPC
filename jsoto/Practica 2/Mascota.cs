/*realizar una clase con el nombre "mascota", que tenga las siguientes 
propiedades: nombre, edad, nombrePropietario, color, categoria). */
//Escribir los siguientes metodos: 
//costructor, 
//Darnormbre (string nombre)
//AsignarColor (String color

using System.Drawing;

public class Mascota
{
    /************
    *propiedades*
    *************/
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
        color = "sin color"; 
        categoria = "sin cantegoria"; 
    }

    public void DarNombre(string valor){
        nombre = valor; 
    }

    public void AsignarColor(string valor){
        color = valor; 

    }
    
}