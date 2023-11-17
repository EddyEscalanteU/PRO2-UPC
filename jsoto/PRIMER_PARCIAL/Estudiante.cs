public class Estudiante
{
    public int Id;
    public string NombreCompleto;
    public int Carnet;
    public int Edad; 


    public Estudiante()
    {
        Id = 0;
        NombreCompleto = "Sin nombre";
        Carnet = 0;
        Edad = 0; 
    }
     public string Mostrar ()
     {
        return "Estudiante{ " + "Nombre: " + NombreCompleto + ",  " +
        "Id: " + Id + ",  " + "carnet: " + Carnet + ",  " + "Edad: " 
        + Edad ;
    
     }

}
