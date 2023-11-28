public class Estudiante{

//Atributos
private int Carnet;
private int CodigoEstudiante;
private string Nombre;
private string ApellidoPaterno;
private string ApellidoMaterno;
private int Edad;
//Constructor
public Estudiante(){
Carnet = 14274252;
CodigoEstudiante = 14274252;
Nombre = "Bryan";
ApellidoPaterno = "Carrasco";
ApellidoMaterno = "Cruz";
Edad = 19;
}
public Estudiante(){
 int Carnet;
 int CodigoEstudiante;
 string Nombre;
 string ApellidoPaterno;
 string ApellidoMaterno;
 int Edad; 
}
public Estudiante(int myCarnet, int myCodigoEstudiante, string myNombre,
string myApellidoPaterno, string myApellidoMaterno, int myEdad){
    Carnet = myCarnet;
    CodigoEstudiante = myCodigoEstudiante;
    Nombre = myNombre;
    ApellidoPaterno = myApellidoPaterno;
    ApellidoMaterno = myApellidoMaterno;
    Edad = myEdad;

}
{
//Metodos(Procedimientos o funcion)
//------------------------------------------Carnet
//funcion
public int GetCarnet()
{
    return Carnet;
}
//procedimiento
public void SetCarnet(int myCarnet){
Carnet = myCarnet;
}
public int GetCodigoEstudiante()
{
    return CodigoEstudiante;
}
//
public void SetCodigoEstudiante(int myCodigoEstudiante){
CodigoEstudiante = myCodigoEstudiante;
}
public int GetNombre()
{
    return Nombre;
}
//
public void SetNombre(int myNombre){
Nombre = myNombre
}

public int GetApellidoPaterno()
{
    return ApellidoPaterno;
}
//
public void SetApellidoPaterno(int myApellidoMaterno){
ApellidoPaterno= myApellidoPaterno
}
public int GetApellidoMaterno()
{
    return ApellidoMaterno;
}
//
public void SetApellidoMaterno(int myApellidoMaterno){
ApellidoMaterno = myApellidoMaterno
}
public int GetEdad()
{
    return Edad;
}
//
public void SetEdad(int myEdad){
Edad = myEdad
}
}
}