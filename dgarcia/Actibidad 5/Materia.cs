public class Materia{
    public string Grupo;
    public string materia;
    public string Docente;
    public Asistencia auxiliar;
    public Materia()
    {
        Grupo = "sin grupo";
        materia = "sin materia";
        Docente = "sin docente";
        auxiliar = new Asistencia();
        
    }
    public void Mostrargrupo(string valor)
    {
        Grupo = valor;
    }
    public void AsignarMateria(string valor)
    {
        materia = valor;
    }
    public string Mostrar(){
        return "Materia { Grupo: " + Grupo + ", " +
        "Materia: " + materia + ", " + 
        "Docente: " + Docente +  ", " + 
        "Auxiliar: " + auxiliar.Mostrar() + " }";    
        }
}