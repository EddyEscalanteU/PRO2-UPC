/// realizar una clase con el nombre 
/// "mascotas"; que tenga las siguientes propiedades: (Nombre, Edad, NombrePropietario, Color, Categoria).
///Escribir los Siguientes matodos:
// DarNombre(String nombre)
//AsignarColor(string Color)


public class mascotas
{

//propiedades

public string nombre;
public int Edad;
//public string NombrePropietario;
public string NombrePropietario;
public string Color;
public string Categoria;

//constructor

public mascotas ()
{

    nombre = "sin nombre";
    Edad = 0;
    NombrePropietario = "sin nombre";
    color = "sin color";
    Categoria = "sin categoria";

}
public void DarNombre(string valor)
{
    nombre = valor;
}

public void AsignarColor(String valor)
{
    color = valor;
}


}



