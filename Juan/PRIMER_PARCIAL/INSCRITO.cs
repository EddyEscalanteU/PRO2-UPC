namespace Primer_Parcial{
public class INSCRITO
{
    private int id;
    private string Fecha;
    private int IdEstudiante;
    private int IdMateria;
    public INSCRITO(){
        id = 0;
        Fecha =0;
        IdEstudiante = 0;
        IdMateria = 0;
    }
    
     public string Mostrar(){
        return "Inscrito {id}";
    }

}
}