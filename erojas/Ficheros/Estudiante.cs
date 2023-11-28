public class Estudiante
{
    // Atributos
    private int Carnet;
    private int CodigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad = 0;
  
    
    // constructor
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
        int myedad)
    {
        Carnet = myCarnet;
        CodigoEstudiante = myCodigoEstudiante;
        Nombre = myNombre;
        ApellidoPaterno = myApellidoPaterno;
        ApellidoMaterno = myApellidoMaterno;
        Edad = myedad;

    }
    // metodos o prodecimientos
    public int getCarnet(){
        return Carnet;
    }
    public void SetCarnet(int myCarnet){
        Carnet = myCarnet;
    }
    public int getCodigoEstudiante(){
        return CodigoEstudiante;
    }
    public void SetCodigoEstudiante(int myCodigoEstudiante){
        CodigoEstudiante = myCodigoEstudiante;
    }
    public string getNombre(){
        return Nombre;
    }
    public void SetNombre(string myNombre){
        Nombre = myNombre;
    }
    public string getApellidoPaterno(){
        return ApellidoPaterno;
    }
    public void SetApellidoPaterno(string myApellidoPaterno){
        ApellidoPaterno = myApellidoPaterno;
    }
    public string getApellidoMaterno(){
        return ApellidoMaterno;
    }
    public void SetApellidoMaterno(string myApellidoMaterno){
        ApellidoMaterno = myApellidoMaterno;
    }
    public int getEdad(){
        return Edad;
    }
    public void SetEdad(int myedad){
        Edad = myedad;    
    }
}