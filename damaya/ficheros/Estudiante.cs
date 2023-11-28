using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Estudiante{
    private int Carnet;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApelidoPaterno;
    private string ApelidoMaterno;
    private int Edad;

    public  Estudiante(){
        Carnet = 0;
        CodigoEstudiante = 0;
        Nombre = "sin nombre";
        ApelidoPaterno = "sin apeido paterno";
        ApelidoMaterno = "sin apellido materno";
        Edad = 0;
    }
    public Estudiante(int MyCarnet, int MyCodigoEstudiante, string MyNombre, string MyApellidoPaterno, string MyApellidoMaterno, int MyEdad){
        Carnet = MyCarnet;
        CodigoEstudiante = MyCodigoEstudiante;
        Nombre = MyNombre;
        ApelidoPaterno = MyApellidoPaterno;
        ApelidoMaterno = MyApellidoMaterno;
        Edad = MyEdad;
    }
    public int GetCarnet(){
        return Carnet;
    }

    public void SetCarnet(int MyCarnet){
        Carnet = MyCarnet;
    }
    public int GetCodigoEstudiante(){
        return CodigoEstudiante;
    }
    public void SetCodigoEstudiante(int MyCodigoEstudiante){
        Carnet = MyCodigoEstudiante;
    }
    public string GetNombre(){
        return Nombre;
    }
    public void SetNombre(string MyNombre){
        Nombre = MyNombre;
    }
    public string GetApellidoPaterno(){
        return ApelidoPaterno;
    }
    public void SetApellidoPaterno(string MyApellidoPaterno){
        ApelidoPaterno = MyApellidoPaterno;
    }
    public string GetApelidoMaterno(){
        return ApelidoMaterno;
    }
    public void SetApelidoMaterno(string MyApelidoMaterno){
        ApelidoMaterno = MyApelidoMaterno;
    }
    public int GetEdad(){
        return Edad;
    }
    public void SetEdad(int MyEdad){
        Edad = MyEdad;
    }
    public void Mostrar(){
        string resultado = "Estudiante: [";
        resultado+= "Carnet = " + GetCarnet() + " ;\n";
        resultado+= "CodigoEstudiante = " + GetCodigoEstudiante() + " ;\n";
        resultado+= "Nombre = " + GetNombre() + " ;\n";
        resultado+= "ApelidoPaterno = " + GetApellidoPaterno() + " ;\n";
        resultado+= "ApelidoMaterno = " + GetApelidoMaterno() + " ;\n";
        resultado+= "Edad = " + GetEdad() + " ;\n";
        resultado+= "]";
        Console.WriteLine(resultado);
    }
}