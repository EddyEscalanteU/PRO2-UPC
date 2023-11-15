public class Persona{
    private int carnet;
    private string nombre;
    private int edad;
    public Persona(){
        carnet = 0;
        nombre = "Sin Nombre";
        edad = 0;
    }
    public Persona(int ci, string name, int myEdad){    
        carnet = ci;
        nombre = name;
        edad = myEdad;
    }
    public string Mostrar(){
        return "Persona { Carnet: " + carnet + ", " +
        "Nombre: " + nombre + ", " +
        "Edad: " + edad + " }";
    }
}