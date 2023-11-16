public class Estudiante
{
    public int ID;

    public string nombreCompleto;

    public int carnet;

    public string genero;

    public int edad;


    public Estudiante()
    {
        ID = 0 ;
        nombreCompleto  ="Sin nombre";
        carnet = 0;
        genero ="Sin genero";
        edad = 0;
    }
    public void AsginarID(int valor)
    {
        ID = 1267;
    }
    public void Asignarnombre(string valor)
    {
        nombreCompleto = valor ;
    }

    public void Asiganagenero(string valor)
    {
        genero = valor ;
    }

    public void AsginarEdad(int valor)
    {
        edad = 21;
    }

    public void AsginarCarnet(int valor)
    {
        ID = 123;
    }

    public string Mostrar()
    {
        return"Nombre :"+ nombreCompleto +  "  ,  " +
        "Edad :" + edad + " ,  " +
        "ID:" + ID + "  ,  " +
        "CARNET :" + carnet + "  ,  " +
        "GENERO :" + genero  ;

    }

}