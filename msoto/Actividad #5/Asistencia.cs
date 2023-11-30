public class Asistencia{
    public string Nombre;
    public string Carrera;
    public string Fecha;
    public int Codigo;
    public int Numero;

    public Asistencia()
    {
        Nombre = " ";
        Carrera = " ";
        Fecha = " ";
        Codigo = 0;
        Numero = 0;
    }

    public Asistencia(string name, string career, string date, int code, int num){
        Nombre = name;
        Carrera = career;
        Fecha = date;
        Codigo = code;
        Numero = num;
    }

    public string Mostrar1(){
        return "Asistencia { Nombre: " + Nombre + ", " +
        "Carrera: " + Carrera + ", " +
        "Fecha: " + Fecha + ", " +
        "Codigo: " + Codigo + ", " +
        "Numero, " + Numero + "}";
    
    }
    
}
