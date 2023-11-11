public class Persona
{
    private int carnet;
    private string nombre;
    private int edad;

    public Persona()
    {
        carnet = 0;
        nombre = "sin nombre";
        edad = 0;
    }

    public Persona(int CI, string name, int myEdad){
        carnet = CI;
        nombre = name;
        edad = myEdad;
    }
    //por que "nombre" esta en privado utlizamos el return 
    public string Mostrar(){
        return "Persona: { Carnet: " + carnet + ", "+ 
        "Nombre: " + nombre + ", " +
        "Edad: " + edad + " }";
        
    }

}