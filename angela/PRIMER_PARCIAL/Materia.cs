public class Materia{

    private string Nombre;
    private string Abreviatura;
    private int Capacidad;
    public Materia(){
         
         Nombre = "sin nombre";
         Abreviatura = "sin abreviatura";
         Capacidad = 0;

        }
    public Materia(string name, string sigla, int  cap){

        Nombre = name;
        Abreviatura = sigla;
        Capacidad = cap;
        
    }
    public string Mostrar(){
        return "Materia { Nombre: " + Nombre + ", " +
           " Abreviatura: " + Abreviatura + ", " +
            " Capacidad: " + Capacidad + " }";
    }

}