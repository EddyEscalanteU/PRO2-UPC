using Microsoft.VisualBasic;

public class Estudiante
{
    //atributos
    private int Carnet;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad;

    //constructor
    public Estudiante()
    {
        Carnet = 0;
        CodigoEstudiante = 0;
        Nombre = "";
        ApellidoPaterno = "";
        ApellidoMaterno = "";
        Edad = 0;
    }

    public Estudiante(int myCarnet, int myCodigoEstudiante, string myNombre, string myApellidoPaterno, string myApellidoMaterno, int myEdad)
    {
        Carnet = myCarnet;
        CodigoEstudiante = myCodigoEstudiante;
        Nombre = myNombre;
        ApellidoPaterno = myApellidoPaterno;
        ApellidoMaterno = myApellidoMaterno;
        Edad = myEdad;

    }

    //metodos (Procedimientos o funciones)

    //funcion
    public int GetCarnet(){
        return Carnet;
    }
    //procedimiento 
    public void SetCarnet(int myCarnet){
        Carnet = myCarnet;
    }

    public int GetCodigoEstudiante(){
        return CodigoEstudiante;
    }
    public void SetCodigoEstudiante(int myCodigoEstudiante){
        CodigoEstudiante = myCodigoEstudiante;
    }

    public string GetNombre(){
        return Nombre;
    }
    public void SetNombre(string myNombre){
        Nombre = myNombre;
    }

    public string GetApellidoPaterno(){
        return ApellidoPaterno;
    }
    public void SetApellidoPaterno(string myApellidoPaterno){
        ApellidoPaterno = myApellidoPaterno;
    }

    public string GetApellidoMaterno(){
        return ApellidoMaterno;
    }
    public void SetApellidoMaterno(string myApellidoMaterno){
        ApellidoMaterno = myApellidoMaterno;
    }
}
