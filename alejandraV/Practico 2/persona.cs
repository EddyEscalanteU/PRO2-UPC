public class Persona {
    private int Carnet;
    private string Nombre;
    private int Edad;

    public Persona(){
        Carnet = 0;
        Nombre = "Sin nombre";
        Edad = 0;

    }
    public Persona(int ci, string name, int myedad){
        Carnet = ci;
        Nombre = name;
        Edad = myedad;

    }

    public string Mostrar(){
        return "Carnet" + Carnet + " " + "Nombre: " + " " + "Edad: " + Edad;
    }

}