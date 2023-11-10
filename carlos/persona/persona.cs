public class Persona{
    private int carnet;
    private string nombre;
    private int edad;
    public Persona(){
        carnet = 8956444;
        nombre = "Carlos";
        edad = 19;
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