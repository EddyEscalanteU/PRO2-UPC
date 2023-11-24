public class Estudiante{
    public int id;
    public string nombrecompleto;
    public int carnet;
    public string genero;
    public int edad;

    public Estudiante(){
        id = 0;
        nombrecompleto = "Sin Nombre";
        carnet = 0;
        genero = "Sin Genero";
        edad = 0;
    }
    public Estudiante(int id, string name, int ci, string sex, int myEdad){    
        id = 0;
        nombrecompleto = name;
        carnet = ci;
        genero = sex;
        edad = myEdad;
    }
    public string Mostrar(){
        return "Estudiante { id: " + id + ", " +"Nombre: " + nombrecompleto + ", " +" Carnet: " + carnet + ", " + 
        "Genero: " + genero + ", "+ "Edad: " + edad + " }";
    }
}