public class Estudiante
{
    private int Carnet;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad;

    public Estudiante()
    {
        Carnet = 0;
        CodigoEstudiante = 0;
        Nombre = "";
        ApellidoPaterno =  "";
        ApellidoMaterno = "";
        Edad = 0;

    }

    public Estudiante(
        int myCarnet,
         int myCodigoEstudiante,
        string myNombre, 
        string myApellidoPaterno, 
        string myApellidoMaterno, 
        int myEdad)
    {
        Carnet =  myCarnet;
        CodigoEstudiante = myCodigoEstudiante;
        Nombre = myNombre;
        ApellidoPaterno = myApellidoPaterno;
        ApellidoMaterno = myApellidoMaterno;
        Edad = myEdad;
    }
    //METODOS (PROCEDIMIENTOS Y FUNCIONES)
    // -------------------CARNET 
    //FUNCION 
    public int Getcanet()
    {
        return Carnet;
    }
    //Procedimiento
    public void SetCarnet(int myCarnet)
    {
        Carnet = myCarnet;
    }

    //--------------CodigoEstudiante
    //funcion
    public int GetCodigoEstudiante()
    {
        return CodigoEstudiante;
    }
    //Procedimiento
    public void SetCodigoEstudiante(int myCodigoEstudiante)
    {
        CodigoEstudiante = myCodigoEstudiante;
    }

    //----------------------Nombre
    //funcion
    public string GetNombre()
    {
        return Nombre;
    }
    //Procedimiento
    public void SetNombre(string myNombre)
    {
        Nombre = myNombre;
    }
    //-----------------Apellido Paterno
    //funcion
    public string SetApellidoPaterno()
    {
        return ApellidoPaterno;
    }
    //Procedimiento
    public void GetApellidoPaterno(string myApellidoPaterno)
    {
        ApellidoPaterno = myApellidoPaterno;
    }
    //--------------Appellido Materno
    //funcion
     public string SetApellidoMaterno()
    {
        return ApellidoMaterno;
    }
    //Procedimiento
    public void GetApellidoMaterno(string myApellidoMaterno)
    {
        ApellidoPaterno = myApellidoMaterno;
    }
    //-------------------- Edad
    //funcion
    public int GetEdad()
    {
        return Edad;
    }
    //Procedimiento
    public void SetEdad(int myEdad)
    {
        Carnet = myEdad;
    }
}