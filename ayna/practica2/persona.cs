public class Persona{
    private int carnet;
    private string nombre;
    private int edad;
    public Persona(){
        carnet = 0;
        nombre = "sin nombre";
        edad = 0;
    }
    public Persona(int ci, string name, int myEdad){
        carnet = co;
        nombre = name;
        edad = myEdad;
    }
    public string mostrar(){
        return "Carnet: "+ carnet + ", "+
        "Nombre: "+ nombre + ", "+
        "Edad: "+ edad;
    }
}