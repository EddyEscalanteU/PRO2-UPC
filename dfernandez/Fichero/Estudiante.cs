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
        CodigoEstudiante = 12345678;
        Nombre = "Adrian Douglas";
        ApellidoPaterno = "Fernandez";
        ApellidoMaterno = "Matos";
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
    public void SetCodigoEstudiante(int MyCodigoEstudiante)
    {
        CodigoEstudiante = MyCodigoEstudiante;

    }

    public string GetNombre()
    {
        return Nombre;

    }
    public void SetNombre(string MyNombre)
    {
        Nombre = MyNombre;

    }
    public string GetApellidoPaterno()
    {
        return ApellidoPaterno;

    }
    public void SetApellidoPaterno(string MyApellidoPaterno)
    {
        Nombre = MyApellidoPaterno;

    }
    public string GetApellidoMaterno()
    {
        return ApellidoMaterno;

    }
    public void SetApellidoMaterno(string MyApellidoMaterno)
    {
        Nombre = MyApellidoMaterno;

    }
        public int GetEdad()
    {
        return Edad;

    }
    public void SetEdad(int MyEdad)
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
    public string[] EstudianteToArray(){
        string[] myArray = new string[6];
        myArray[0] = GetCarnet() + "";
        myArray[1] = GetCodigoEstudiante() + "";
        myArray[2] = GetNombre() + "";
        myArray[3] = GetApellidoPaterno() + "";
        myArray[4] = GetApellidoMaterno() + "";
        myArray[5] = GetEdad() + "";
        return myArray;

    }
    public void ArrayToEstudiante(string[] lineas){
        int lineaCarnet = int.Parse(lineas[0]);
        int lineaCodigoEstudiante = int.Parse(lineas[1]);
        string lineaNombre = lineas[2];
        string lineaApellidoPaterno = lineas[3];
        string lineaApellidoMaterno = lineas[4];
        int lineaEdad = int.Parse(lineas[5]);

        SetCarnet(lineaCarnet);
        SetCodigoEstudiante(lineaCodigoEstudiante);
        SetNombre(lineaNombre);
        SetApellidoPaterno(lineaApellidoPaterno);
        SetApellidoMaterno(lineaApellidoMaterno);
        SetEdad(lineaEdad);
    }

}