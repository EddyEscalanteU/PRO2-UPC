public class Asistencia{
    public string Nombre;
    public string Carrera;
    public string Fecha;
    public int codigo;
    public int Numero;
    public Asistencia(){
        Nombre = "sin nombre";
        Carrera = "sin asignar";
        Fecha = "viernes";
        codigo = 0;
        Numero = 0;
    }
    public void DarNombre(string valor)
    {
        Nombre = valor;
    }
    public void MostrarCarrera(string valor)
    {
        Carrera = valor;
    }
    
    

}