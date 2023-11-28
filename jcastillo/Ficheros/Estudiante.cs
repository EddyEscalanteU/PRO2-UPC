using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Estudiante
{
    //Atributos
    private int Carnet;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad;

    //Constructor
    public Estudiante()
    {
        Carnet = 0;
        CodigoEstudiante = 0;
        Nombre = "";
        ApellidoPaterno = "";
        ApellidoMaterno = "";
        Edad = 0;
    }

    public Estudiante(
        int myCarnet,
        int myCodigoEstudiante,
        string myNombre,
        string myApellidoPaterno,
        string myApellidoMaterno,
        int myEdad
    )
    {
        Carnet = myCarnet;
        CodigoEstudiante = myCodigoEstudiante;
        Nombre = myNombre;
        ApellidoPaterno = myApellidoPaterno;
        ApellidoMaterno = myApellidoMaterno;
        Edad = myEdad;
    }

    //Metodos(Procedimientos o Funciones)
    //-----------------------Carnet
    //funcion
    public int GetCarnet()
    {
        return Carnet;
    }

    //procedimiento
    public void SetCarnet(int myCarnet)
    {
        Carnet = myCarnet;
    }

    //-----------------------CodigoEstudiante
    public int GetCodigoEstudiante()
    {
        return CodigoEstudiante;
    }

    public void SetCodigoEstudiante(int myCodigoEstudiante)
    {
        CodigoEstudiante = myCodigoEstudiante;
    }

    //-----------------------Nombre
    public string GetNombre()
    {
        return Nombre;
    }

    public void SetNombre(string myNombre)
    {
        Nombre = myNombre;
    }

    //-----------------------ApellidoPaterno
    public string GetApellidoPaterno()
    {
        return ApellidoPaterno;
    }

    public void SetApellidoPaterno(string myApellidoPaterno)
    {
        ApellidoPaterno = myApellidoPaterno;
    }

    //-----------------------ApellidoMaterno
    public string GetApellidoMaterno()
    {
        return ApellidoMaterno;
    }

    public void SetApellidoMaterno(string myApellidoMaterno)
    {
        ApellidoMaterno = myApellidoMaterno;
    }

    //-----------------------Edad
    public int GetEdad()
    {
        return Edad;
    }

    public void SetEdad(int myEdad)
    {
        Edad = myEdad;
    }

    public void Mostrar(){
        string resultado = "Estudiante: [\n";
        resultado+= "Carnet = " + GetCarnet() + " ;\n";
        resultado+= "CodigoEstudiante = " + GetCodigoEstudiante() + " ;\n";
        resultado+= "Nombre = " + GetNombre() + " ;\n";
        resultado+= "ApellidoPaterno = " + GetApellidoPaterno() + " ;\n";
        resultado+= "ApellidoMaterno = " + GetApellidoMaterno() + " ;\n";
        resultado+= "Edad = " + GetEdad() + " ;\n";
        resultado+= "]";
        Console.WriteLine(resultado);
    }
}