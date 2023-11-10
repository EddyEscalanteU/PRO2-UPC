public class Persona{
    private int carnet;
    private string Nombre;
    private int edad;
    public Persona(){
        carnet = 0;
        Nombre = "Sin nombre";
        edad = 0;
    }
    public Persona(int ci, string name, int myEdad){
        carnet = ci;
        Nombre = name;
        edad = myEdad;
    }
    public string Mostrar(){
        return "Persona { carnet: " + carnet + ", " +
        "Nombre: " + Nombre + ", " +
        "Edad: " + edad + "}";
    }
}