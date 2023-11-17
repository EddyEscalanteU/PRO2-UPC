public class Inscrito{
    public int Id;
    public string Fecha;
    public string IdEstudiante;
    public string IdMateria;
    public Inscrito(){
        Id = 7785;
        Fecha = "2/11/2023";
        IdEstudiante = "12548";
        IdMateria = "Programacion2";
    }
    public Inscrito(int MyId, string MyFecha, string MyIdEstudiante, string MyIdMateria){    
        Id = MyId;
        Fecha = MyFecha;
        IdEstudiante = MyIdEstudiante;
        IdMateria = MyIdMateria;
    }

    public string Mostrar(){
        return "Inscrito { Id: " + Id + ", " +
        "Fecha: " + Fecha + ", " +
        "IdEstudiante: " + IdEstudiante + ", " +
        "IdMateria: " + IdMateria + " }";
    }
}