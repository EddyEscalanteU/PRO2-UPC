public class Asistencia{
    public string Nombre;
    public string Carrera;
    public string dia;
    public int codigo;
    public int numero;
    public Asistencia(){
        Nombre = "sin nombre";
        Carrera = "sin asignar";
        dia = "viernes";
        codigo = 0;
        numero = 0;
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