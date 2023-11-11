//realizar una clase con el nombre
// "Materia1", que tenga las siguientes propiedades (Grupo, Materia, Docente, Periodo, Hora).
//Escribir los siguientes metodos:
//DarNombre(string grupo)
//AsignarMateria(string Materia)
//DarNombre(string docente)
 
public class Materia1
{
        public string Grupo;
        public string Materia;
        public string Docente;
        public int Hora;

public Materia1()
{

    Grupo = "sin grupo";
    Materia = "sistema";
    Docente = "sin docente";
    Hora = 0;

}
public void DarNombre(string valor)
{ 
    Docente = valor;
}
public void AsignarMateria(string valor)
{
    Materia = valor;
    }


}