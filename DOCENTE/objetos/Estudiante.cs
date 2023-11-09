public class Estudiante{
    //Las Propiedades
   public string nombre;
   public int edad;
   public int nota;

    //El Constructor (procedimiento por defecto, que se ejecuta la primera vez)
    public Estudiante(){
        nombre = "Sin Nombre";
        edad = 100;
        nota = 100;
    }

    public void SetNombre(string valor){
        nombre = valor;
    }

    public void RestarEdad(int valor){
        edad = edad - valor;
    }

     public void AplazarEstudiante(){
        nota = 49;
    }

    public void AgregarPuntosExtra(int puntos){
        nota = nota + puntos;
    }

    public string AprobadoReprobado(){
        if(nota >= 51){
            return "Aprobado";
        }else{
            return "Reprobado";
        }
    }

}