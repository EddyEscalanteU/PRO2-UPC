public class Estudiante{
    //atributos
    private int carnet;
    private int codigoEstudiante;
    private string Nombre;
    private string ApellidoPaterno;
    private string ApellidoMaterno;
    private int Edad;

    //constructor
    public Estudiante(){

        carnet = 0;
        codigoEstudiante = 5;
        Nombre = "noelia";
        ApellidoPaterno = " ";
        ApellidoMaterno = "";
        Edad = 11;
    }
    public Estudiante(int myCarnet, myCodigoEstudiante, string myNombre, myApellidoPaterno, myApellidoMaterno, int myEdad){
   
        carnet = myCarnet;
        codigoEstudiante = myCodigoEstudiante;
        Nombre = myNombre;
        ApellidoPaterno = myApellidoPaterno;
        ApellidoMaterno = myApellidoMaterno;
        Edad = myEdad;
       
    //Metodos(procedimientos o funcion)
//----------------------------Carnet
    public int GetCarnet()
    {
         return carnet
    }
    public void SetCarnet(int myCarnet)
    {
        carnet = myCarnet;
    }
//-----------------------------CodigoEstudiante
     public int GetCodigoEstudiante()
     {
        return codigoEstudiante
     }
     Public void SetCodigoEstudiante(int myCodigoEstudiante)
     {
        codigoEstudiante = myCodigoEstudiante;
     }
//------------------------------Nombre
     public string GetNombre()
     {
        return Nombre
     }
     Public void SetNombre(string myNombre)
     {
        Nombre = myNombre;
     }
//----------------------------ApellidoPaterno
 public string GetApellidoPaterno()
     {
        return ApellidoPaterno
     }
     Public void SetApellidoPaterno(string myApellidoPaterno)
     {
        ApellidoPaterno = myApellidoPaterno;
     }
//----------------------------ApellidoMaterno
       public string GetApellidoMaterno()
     {
        return ApellidoMaterno
     }
     Public void SetApellidoMaterno(string myApellidoMaterno)
     {
        ApellidoMaterno = myApellidoMaterno;
     } 
//---------------------------Edad
    public int GetEdad()
    {
         return Edad
    }
    public void SetEdad(int myEdad)
    {
        Edad = myEdad;
    }

     }
}