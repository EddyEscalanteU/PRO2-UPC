public class Estudiante
{
    private int carnet;
    private int codigoEstudiante;
    private string nombre;
    private string apellidoPaterno;
    private string apellidoMaterno;
    private int edad;
    //-------------------------Constructor
    public Estudiante()
    {
        carnet = 0;
        codigoEstudiante = 0;
        nombre = "";
        apellidoPaterno = "";
        apellidoMaterno = "";
        edad = 0;
    }
    //-----------------------------Parametro
    public Estudiante(int mycarnet, int mycodigoEstudiante, string mynombre, string myapellidoPaterno, string myapellidoMaterno, int myEdad)
    {
        carnet = mycarnet;
        codigoEstudiante = mycodigoEstudiante;
        nombre = mynombre;
        apellidoPaterno = myapellidoPaterno;
        apellidoMaterno = myapellidoMaterno;
        edad = myEdad;
    }
    //-----------------------------CARNET
    public int GetCarnet()
    {
        return carnet;
    }

    public void SetCarnet(int mycarnet)
    {
        carnet = mycarnet;
    }
    //--------------------------------CODIGO ESTUDIANTE
    public int GetCodigoEstudiante()
    {
        return codigoEstudiante;
    }

    public void SetCodigoEstudiante(int mycodigoEstudiante)
    {
        codigoEstudiante = mycodigoEstudiante;
    }
    //--------------------------------NOMBRE
    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string mynombre)
    {
        nombre = mynombre;
    }
    //-------------------------APELLIDO PATERNO
    public string GetApellidoPaterno()
    {
        return apellidoPaterno;
    }
    
    public void SetApellidoPaterno(string myapellidoPaterno)
    {
        apellidoPaterno = myapellidoPaterno;
    }
    //-------------------------APELLIDO MATERNO
    public string GetApellidoMaterno()
    {
        return apellidoMaterno;
    }

    public void SetApellidoMaterno(string myapellidoMaterno)
    {
        apellidoMaterno = myapellidoMaterno;
    }
    //-----------------------------EDAD
    public int GetEdad()
    {
        return edad;
    }

    public void SetEdad(int myEdad)
    {
        edad = myEdad;
    }
    public void Mostrar()
    {
        string resultado = "Estudiante: [\n";
        resultado+= "Carnet = " + GetCarnet() + " ;\n";
        resultado+= "CodigoEstudiante = " + GetCodigoEstudiante()+ " ;\n";
        resultado+= "Nombre = " + GetNombre() + " ;\n";
        resultado+= "ApellidoPaterno = " + GetApellidoPaterno() + " ;\n";
        resultado+= "ApellidoMaterno = " + GetApellidoMaterno() + " ;\n";
        resultado+= "Edad = " + GetEdad()+ " ;\n";
        resultado+= "]";
        Console.WriteLine(resultado);
    }
    public string[] EstudianteToArray()
    {
        string[] myArray = new  string[6];
        myArray[0] = GetCarnet() + "";
        myArray[1] = GetCodigoEstudiante() + "";
        myArray[2] = GetNombre() + "";
        myArray[3] = GetApellidoPaterno();
        myArray[4] = GetApellidoMaterno();
        myArray[5] = GetEdad() + "";
        return myArray;
    }
    public void ArrayToEstudiante(string[] lineas)
    {
        int lineasCarnet = int.Parse(lineas[0]);
        int lineasCodigoEstudiante = int.Parse(lineas[1]);
        string lineasNombre = lineas[2];
        string lineasApellidoPaterno = lineas[3];
        string lineasApellidoMaterno = lineas[4];
        int lineasEdad = int.Parse(lineas[5]);
        SetCarnet(lineasCarnet);
        SetCodigoEstudiante(lineasCodigoEstudiante);
        SetNombre(lineasNombre);
        SetApellidoPaterno(lineasApellidoPaterno);
        SetApellidoMaterno(lineasApellidoMaterno);
        SetEdad(lineasEdad);
    }
}

