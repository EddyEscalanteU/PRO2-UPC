using System.Security.Cryptography.X509Certificates;

public class Estudiante{
    private string Nombre;
    private string Apellido;
    private int Edad;
    private int CodigoEstudiante;
    private int Carnet;
    private string ApellidoPaterno;
    private string ApellidoMaterno;

    public Estudiante(){
        Nombre = "Douglas";
        Apellido = "Fernandez Matos";
        Edad = 19;
        CodigoEstudiante = 9595866;
        Carnet = 9775810;
        ApellidoPaterno = "Fernandez";
        ApellidoMaterno = "Matos";

    }
    public Estudiante(
        string MyNombre, 
        string MyApellido, 
        int MyEdad,
        int MyCodigoEstudiante, 
        int MyCarnet, 
        string MyApellidoPaterno, 
        string MyApellidoMaterno)
    {
        Carnet = MyCarnet;
        CodigoEstudiante = MyCodigoEstudiante;
        Nombre = MyNombre;
        Apellido = MyApellido;
        ApellidoPaterno = MyApellidoPaterno;
        ApellidoMaterno = MyApellidoMaterno;
        Edad = MyEdad;



    }

    public int GetCarnet(){
        return Carnet;
    }

    public void SetCarnet(int MyCarnet)
    {
        Carnet = MyCarnet;
    }
    public int GetCodigoEstudiante(){
        return CodigoEstudiante;

    }
    public void setCodigoEstudiante(int MyCodigoEstudiante)
    {
        CodigoEstudiante = MyCodigoEstudiante;

    }
    public int GetEdad()
    {
        return Edad;

    }
    public void setEdad(int MyEdad)
    {
        Edad = MyEdad;
    }
    public string GetNombre()
    {
        return Nombre;

    }
    public void setNombre(string MyNombre)
    {
        Nombre = MyNombre;

    }
    public string GetApellido()
    {
        return Apellido;

    }
    public void setApellido(string MyApellido)
    {
        Nombre = MyApellido;

    }
    public string GetApellidoPaterno()
    {
        return ApellidoPaterno;

    }
    public void setApellidoPaterno(string MyApellidoPaterno)
    {
        Nombre = MyApellidoPaterno;

    }
    public string GetApellidoMaterno()
    {
        return ApellidoMaterno;

    }
    public void setApellidoMaterno(string MyApellidoMaterno)
    {
        Nombre = MyApellidoMaterno;

    }

}