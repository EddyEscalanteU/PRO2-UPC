public class Estudiante{
    private int Carnet;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad;
    
    public Estudiante(){

        Carnet = 0;
        CodigoEstudiante = 0;
        Nombre = "";
        ApellidoPaterno = "";
        ApellidoMaterno = "";
        Edad = 0;

    }

    public Estudiante(int mycarnet, int mycestudiante, string mynombre, string myapaterno, string myamaterno, int myedad ){

       Carnet = mycarnet;
       CodigoEstudiante = mycestudiante;
       Nombre = mynombre;
       ApellidoPaterno = myapaterno;
       ApellidoMaterno = myamaterno;
       Edad = myedad;

    }

    public int GetCarnet()
    {
        return Carnet;
    }

    public void SetCarnet( int mycarnet)
    {
        Carnet = Carnet;
    }

    public int GetCodigoEstudiante()
    {
        return CodigoEstudiante;
    }

    public void SetCodigoEstudiante( string mycestudiante)
    {
        CodigoEstudiante = CodigoEstudiante;
    }

    public string GetNombre()
    {
        return Nombre;
    }

    public void SetNombre( int mynombre)
    {
        Nombre= Nombre;
    }

    public string GetApellidoPaterno()
    {
        return ApellidoPaterno;
    }

    public void SetApellidoPaterno( string myapaterno)
    {
       ApellidoPaterno = ApellidoPaterno;
    }

    public string GetpellidoMaterno()
    {
        return ApellidoMaterno;
    }

    public void SetApellidoMaterno( string myamaterno)
    {
        ApellidoMaterno = ApellidoMaterno;
    }

    public int GetEdad()
    {
        return Edad;
    }

    public void SetEdad( int myedad)
    {
        Edad = Edad;
    }



}