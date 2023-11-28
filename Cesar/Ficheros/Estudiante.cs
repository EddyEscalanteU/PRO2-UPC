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
        Carnet = mycarnet;
    }

    public int GetCodigoEstudiante()
    {
        return CodigoEstudiante;
    }

    public void SetCodigoEstudiante( int mycestudiante)
    {
        CodigoEstudiante = mycestudiante;
    }

    public string GetNombre()
    {
        return Nombre;
    }

    public void SetNombre( string mynombre)
    {
        Nombre= mynombre;
    }

    public string GetApellidoPaterno()
    {
        return ApellidoPaterno;
    }

    public void SetApellidoPaterno( string myapaterno)
    {
       ApellidoPaterno = myapaterno;
    }

    public string GetApellidoMaterno()
    {
        return ApellidoMaterno;
    }

    public void SetApellidoMaterno( string myamaterno)
    {
        ApellidoMaterno = myamaterno;
    }

    public int GetEdad()
    {
        return Edad;
    }

    public void SetEdad( int myedad)
    {
        Edad = myedad;
    }

    public void Mostrar (){
        string resultado = "Estudiante: [\n";
        resultado+= "Carnet = " + GetCarnet() + ";\n";
        resultado+= "CodigoEstudiante = " + GetCodigoEstudiante() + ";\n";
        resultado+= "Nombre = " + GetNombre() + ";\n";
        resultado+= "ApellidoPaterno = " + GetApellidoPaterno() + ";\n";
        resultado+= "ApellidoMaterno = " + GetApellidoMaterno() + ";\n";
        resultado+= "Edad = " + GetEdad() + ";\n";  
        resultado+= "]";


    }



}