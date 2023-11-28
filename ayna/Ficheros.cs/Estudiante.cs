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
        codigoEstudiante = 0;
        Nombre = "Nelson";
        ApellidoPaterno = " ";
        ApellidoMaterno = " ";
        Edad = 0;
    }
    public Estudiante(int myCarnet, int myCodigoEstudiante, string myNombre, string myApellidoPaterno, string myApellidoMaterno, int myEdad){
   
        carnet = myCarnet;
        codigoEstudiante = myCodigoEstudiante;
        Nombre = myNombre;
        ApellidoPaterno = myApellidoPaterno;
        ApellidoMaterno = myApellidoMaterno;
        Edad = myEdad;
    }
    //Metodos(procedimientos o funcion)
//----------------------------Carnet
    public int GetCarnet()
    {
         return carnet;
    }
    public void GetCarnet(int myCarnet)
    {
        carnet = myCarnet;
    }
//-----------------------------CodigoEstudiante
     public int GetCodigoEstudiante()
     {
        return codigoEstudiante;
     }
     public void SetCodigoEstudiante(int myCodigoEstudiante)
     {
        codigoEstudiante = myCodigoEstudiante;
     }
//------------------------------Nombre
     public string GetNombre()
     {
        return Nombre;
     }
     public void SetNombre(string myNombre)
     {
        Nombre = myNombre;
     }
//----------------------------ApellidoPaterno
 public string GetApellidoPaterno()
     {
        return ApellidoPaterno;
     }
     public void SetApellidoPaterno(string myApellidoPaterno)
     {
        ApellidoPaterno = myApellidoPaterno;
     }
//----------------------------ApellidoMaterno
       public string GetApellidoMaterno()
     {
        return ApellidoMaterno;
     }
     public void SetApellidoMaterno(string myApellidoMaterno)
     {
        ApellidoMaterno = myApellidoMaterno;
     } 
//---------------------------Edad
    public int GetEdad()
    {
         return Edad;
    }
    public void SetEdad(int myEdad)
    {
        Edad = myEdad;
    }
     
     public void Mostrar(){
        string resultado = "Estudiante: [\n";
        resultado+= "Carnet = " + GetCarnet() + " ;\n";
        resultado+= "CodigoEstudiante = " + GetCodigoEstudiante() + " ;\n";
        resultado+= "Nombre = " + GetNombre() + " ;\n";
        resultado+= "ApellidoPaterno = " + GetApellidoPaterno() + " ;\n";
        resultado+= "ApellidoMaterno = " + GetApellidoMaterno() + " ;\n";
        resultado+= "Edad = " + GetEdad() + " ;\n";
        resultado+= "]";
        Console.WriteLine(resultado);
     }

}

