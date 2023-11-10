public class Asistencia{
    public int Codigo;
    public string Nombre;
    public int Carnet;
    public Asistencia(){
        Codigo = 0;
        Nombre = "sin nombre";
        Carnet = 0;
    }
    public Asistencia(int myCodigo, string name, int ci){
        Codigo = myCodigo;
        Nombre = name;
        Carnet = ci;
    }
    public string Mostrar(){
        return "Asistencia { Codigo: " + Codigo + ", " +
        "Nombre: " + Nombre + ", "+ 
        "Carnet: " + Carnet + " }";
    }
}