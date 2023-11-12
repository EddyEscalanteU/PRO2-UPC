//realizar una clase con el nombre
// "Materia1", que tenga las siguientes propiedades (Grupo, Materia, Docente, Periodo, Hora).
//Escribir los siguientes metodos:
//DarNombre(string grupo)
//AsignarMateria(string Materia)
//DarNombre(string docente)
 
public class Materia
{
        public string Grupo;
        public string Materia;
        public string Docente;
        public int Hora;
        public Materia()
{

    Grupo = "sin grupo";
    Materia = "sin nombre";
    Docente = "sin docente";
    Hora = 0;

}
public Materia(string grupo, string materia1, string Docente1, int Hora1){

    grupo = group;
    materia = materia1
    docente = Docente1
    hora = hora1
}
 
public string Mostrar(){
    retun "materia { grupo: " + Grupo + ", " +
    "materia: " + materia + ", " +
    "docente: " + docente + ", " +
    "hora: " + hora + "}" +;

}

}