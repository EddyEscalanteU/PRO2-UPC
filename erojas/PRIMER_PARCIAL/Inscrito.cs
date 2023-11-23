public class Inscrito{
    private int Id;
    private string NombreCompleto;
    private int Carnet;
    private int Genero;
    private int Edad;
    public Inscrito(){
        Id = 0;
        NombreCompleto = "Elias Rojas Ledezma";
        Carnet = 7923832;
        Genero = 0;
        Edad = 0;
    }
    public Inscrito(int ci, string nombreCompleto,int carnet ,int myEdad, int Idgenero){    
        Id = ci;
        NombreCompleto = nombreCompleto;
        Carnet = carnet;
        Genero = Idgenero;
        Edad= myEdad;
    }
    public string Mostrar(){
        return "Inscrito { Id: " + Id + " " +
        "NombreCompleto: " + NombreCompleto + ", " +
        "Carnet :" + Carnet +" " +"Genero: " + " " + Genero + " " +"Edad: " + Edad +" }";
    }
}