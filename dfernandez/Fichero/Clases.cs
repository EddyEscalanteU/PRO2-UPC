using System.Security.Cryptography.X509Certificates;

public class Estudiante{
    private int Carnet;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad;

    public Estudiante(){
        Carnet = 9775810;
        CodigoEstudiante = 9595866;
        Nombre = " ";
        ApellidoPaterno = " ";
        ApellidoMaterno = " ";
        Edad = 19;

    }
    public Estudiante(
        int MyCarnet, 
        int MyCodigoEstudiante,
        string MyNombre, 
        string MyApellidoPaterno, 
        string MyApellidoMaterno,
        int MyEdad)
        
    {
        Carnet = MyCarnet;
        CodigoEstudiante = MyCodigoEstudiante;
        Nombre = MyNombre;
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

    public string GetNombre()
    {
        return Nombre;

    }
    public void setNombre(string MyNombre)
    {
        Nombre = MyNombre;

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
        public int GetEdad()
    {
        return Edad;

    }
    public void setEdad(int MyEdad)
    {
        Edad = MyEdad;
    }
    public void Mostrar(){
        string resultado = "Estudiante: [";
        resultado+= "Carnet = " + GetCarnet() + " ; \n";
        resultado+= "CodigoEstudiante = " + GetCodigoEstudiante() + " ; \n";
        resultado+= "Nombre = " + GetNombre() + " ; \n";
        resultado+= "ApellidoPaterno = " + GetApellidoPaterno() + " ; \n";
        resultado+= "ApellidoMaterno = " + GetApellidoMaterno() + " ; \n";
        resultado+= "Edad = " + GetEdad() + " ; \n";
        resultado+= "]";
        Console.WriteLine(resultado);
    }

}