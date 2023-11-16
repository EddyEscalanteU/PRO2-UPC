public class Estudiante{
    //Las Propiedades
   public int Id;
   public string NombreCompleto;
   public int Carnet;
   public string Genero; 
   public int Edad;
    //El Constructor (procedimiento por defecto, que se ejecuta la primera vez)
    public Estudiante(){
        Id = 4;
        NombreCompleto = "Diego Garcia";
        Carnet  = 0545482;
        Genero = "Masculino";
        Edad = 27;
    }
    public string Mostrar(){
        return "Estudiante: { Id: " + Id + ", " +
        "NombreCompleto: " + NombreCompleto + ", " +
        "Carnet: " + Carnet + ", " +
        "Genero: " + Genero + ", " +
        "Edad: " + Edad + "}";
    }
}
