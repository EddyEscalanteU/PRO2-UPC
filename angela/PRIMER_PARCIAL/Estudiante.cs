public class Estudiante{

    private string NombreCompleto;
    private int Carnet;
    private string Genero;
    private int Edad;
    public Estudiante(){
         
         NombreCompleto = "Sin Nombre";
         Carnet = 0;
         Genero = "Sin Genero";
         Edad = 0;

        }
    public Estudiante(string name, int ci, string myGenero, int youEdad){

        NombreCompleto = name;
        Carnet = ci;
        Genero = myGenero;
        Edad = youEdad;
    }
    public string Mostrar(){
        return "Estudiante { NombreCompleto: " + NombreCompleto + ", " +
           " Carnet: " + Carnet + ", " +
            " Genero: " + Genero + ", " +
            " Edad: " + Edad + " }";
    }

}