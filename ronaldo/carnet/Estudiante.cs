public class Estudiante 

{
    private int Carnet ;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad;

    public Estudiante()
    {
        Carnet = 0;
        CodigoEstudiante = 0;
        Nombre =" ";
        ApellidoPaterno =" ";
        ApellidoMaterno =" ";
        Edad = 0 ;
    }

    public Estudiante(int mycarnet,int myCodigoEstudiante,string myNombre,string myApellidoPaterno,string myApellidoMaterno, int myEdad )
    {
        Carnet = mycarnet;
        CodigoEstudiante = myCodigoEstudiante;
        Nombre= myNombre;
        ApellidoMaterno= myApellidoMaterno;
        ApellidoPaterno = myApellidoPaterno;
    }

    public int Getcarnet()
    {
        return Carnet ;
    } 

    public void setCarnet(int mycarnet)
    {
        Carnet = mycarnet;
    }

    public int GetCodigoEstudiante()
    {
        return CodigoEstudiante;
    }

    public void SetCodigoEstudiante(int myCodigoEstudiante)
    {
        CodigoEstudiante = myCodigoEstudiante;
    }

    public string GeTApellidoPaterno()
    {
        return ApellidoPaterno;
    }

    public void setApeliidoPaterno(string myApellidoPaterno)
    {
        ApellidoPaterno = myApellidoPaterno;
    }

    public string GeTApellidoMaterno()
    {
        return ApellidoMaterno;
    }

    public void setApellidoMaterno(string myApellidoMaterno)
    {
        ApellidoMaterno = myApellidoMaterno;
    }
    public int GetEdad()
    {
        return Edad;
    }

    public void SetEdad(int myEdad)
    {
        Edad = myEdad;
    }

    public void Mostrar()
    {
    string resultado ="Estudiante :\n ";
    resultado +="carnet = "+ Getcarnet() + ";\n";
    resultado +="CodigoEstudiante = "+ GetCodigoEstudiante() + ";\n";
    resultado +="ApellidoPaterno = "+ GeTApellidoPaterno() + ";\n";
    resultado +="ApellidoMaterno = "+ GeTApellidoMaterno() + ";\n";
    resultado +="Edad = "+ GetEdad() + ";\n";

    Console.WriteLine();
    }
    

}