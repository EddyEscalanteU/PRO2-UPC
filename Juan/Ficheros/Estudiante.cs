public class Estudiante
{
    private int carnet;
    private int codigoEstudiante;
    private string nombre;
    private string apellidoPaterno;
    private string apellidoMaterno;
    private int edad;

    public Estudiante()
    {
        carnet = 0;
        codigoEstudiante = 0;
        nombre = "";
        apellidoPaterno = "";
        apellidoMaterno = "";
        edad = 0;
    }

    public Estudiante(int mycarnet, int mycodigoEstudiante, string mynombre, string myapellidoPaterno, string myapellidoMaterno, int myEdad)
    {
        carnet = mycarnet;
        codigoEstudiante = mycodigoEstudiante;
        nombre = mynombre;
        apellidoPaterno = myapellidoPaterno;
        apellidoMaterno = myapellidoMaterno;
        edad = myEdad;
    }

    public int GetCarnet()
    {
        return carnet;
    }

    public void SetCarnet(int mycarnet)
    {
        carnet = mycarnet;
    }

    public int GetCodigoEstudiante()
    {
        return codigoEstudiante;
    }

    public void SetCodigoEstudiante(int mycodigoEstudiante)
    {
        codigoEstudiante = mycodigoEstudiante;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string mynombre)
    {
        nombre = mynombre;
    }

    public string GetApellidoPaterno()
    {
        return apellidoPaterno;
    }

    public void SetApellidoPaterno(string myapellidoPaterno)
    {
        apellidoPaterno = myapellidoPaterno;
    }

    public string GetApellidoMaterno()
    {
        return apellidoMaterno;
    }

    public void SetApellidoMaterno(string myapellidoMaterno)
    {
        apellidoMaterno = myapellidoMaterno;
    }

    public int GetEdad()
    {
        return edad;
    }

    public void SetEdad(int myEdad)
    {
        edad = myEdad;
    }
}

