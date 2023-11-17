namespace Primer_Parcial{
public class Estudiante
{
    private int id;
    private string NombreCompleto;
    private int carnet;
    private string Genero;
    private int edad;
    public Estudiante(){
        id = 0;
        NombreCompleto ="Sin nombre";
        carnet = 0;
        Genero = "vacio ";
        edad = 0;
    }
    public Estudiante(int ID, string NOMC,int CI, string MF, int MyEdad){
        id = ID;
        NombreCompleto = NOMC;
        carnet = CI ;
        Genero = MF;
        edad = MyEdad;
    }
    public string Mostrar(){
        return "Estudiante {id:" + id + "canet: " + carnet + "nombre" + NombreCompleto + "genero: " + Genero + "edad: " + edad " }";
    }

}
}