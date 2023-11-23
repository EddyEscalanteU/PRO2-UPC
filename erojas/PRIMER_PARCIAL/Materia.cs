public class Materia{
    private int Id;
    private string nombre;
    private string Abreviatura;
    private int Capacidad;
    public Materia(){
        Id = 0;
        Abreviatura = "PRO 02";
        nombre = "Programacion 2";
        Capacidad = 0;
    }
    public Materia(int ci, string name, int myEdad, string abreviatura){    
        Id = ci;
        nombre = name;
        Abreviatura = abreviatura;
        Capacidad = myEdad;
    }
    public string Mostrar(){
        return "Materia { Id: " + Id + ", " +
        "Nombre: " + nombre + ", " +
        "Capacidad: " + Capacidad + " " +"Abreviatura: " + Abreviatura +" }";
    }
}