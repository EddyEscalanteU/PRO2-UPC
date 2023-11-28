public class Estudiante{
    private int carnet;
    private int codigoEstudiante;
    private string nombre;
    private string apellidoPaterno;
    private string apellidoMaterno;
    private int edad;


    public Estudiante(){
        carnet = 0;
        codigoEstudiante = 0;
        nombre = "";
        apellidoPaterno = "";
        apellidoMaterno = "";
        edad = 0;
    }

    public Estidante(int myCarnet, int myCodigoEstudiante
    , string myNombre, string myApellidoPaterno,
    string myApellidoMaterno, int myEdad){
        carnet = myCarnet;
        codigoEstudiante = myCodigoEstudiante;
        nombre = myNombre;
        apellidoPaterno = myApellidoPaterno;
        apellidoMaterno = myApellidoMaterno;
        edad = myEdad;
    }

    public int GetCarnet(){
     return carnet;
    }

    public void SetCarnet(int myCarnet){
        carnet = myCarnet
    }

    public int GetCodigoEstudiante(){
     return codigoEstudiante;
    }

    public void SetCodigoEstudiante(int myCodigoEstudiante){
        codigoEstudiante = myCodigoEstudiante;
    }

    public int GetNombre(){
     return nombre;
    }

    public void SetCarnet(string myNombre){
        nombre = myNombre;
    }

    public int GetApellidoPaterno(){
     return apellidoPaterno;
    }

    public void SetApellidoPaterno(int myApellidoPaterno){
        apellidoPaterno = myApellidoPaterno;
    }

    public int GetApellidoMaterno(){
     return apellidoMaterno;
    }

    public void GetApellidoMaterno(int myApellidoMaterno){
        apellidoMaterno = myApellidoMaterno
    }

    public int GetEdad(){
     return edad;
    }

    public void SetEdad(int myEdad){
        edad = myEdad;
    }
}