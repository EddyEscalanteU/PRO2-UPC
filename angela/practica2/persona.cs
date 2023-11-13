public class persona{

    private int carnet;
    private string nombre;
    private int edad;

    public persona(){
        carnet = 0;
        Nombre = "Sin Nombre";
        edad = 0;

    }

    public Persona(int ci, string name, int myEdad){
         carnet = ci;
         nombre = name;
         edad = myEdad;
    }

    public string mostrar(){
        return  "Persona { carnet: "+ carnet + ", " +
        "Nombre: " + nombre + ", " +
        "Edad: " + edad + " }";
    }
}