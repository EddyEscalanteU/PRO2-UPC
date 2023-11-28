public class Estudiante{
//atributos
private int carnet;
private int CodigoEstudiante;
private string Nombre;
private string ApellidoPaterno;
private string ApellidoMaterno;
private int Edad;

//constructor
public Estudiante(){
    carnet = 0;
    CodigoEstudiante = 0;
    Nombre = "";
    ApellidoPaterno = "";
    ApellidoMaterno = "";
    Edad = 0;
}
public Estudiante(int myCarnet, int myCodigoEstudiante, string myNombre, string myApellidoPaterno, string myApellidoMaterno, int myEdad){
carnet = myCarnet;
CodigoEstudiante = myCodigoEstudiante;
Nombre = myNombre;
ApellidoPaterno = myApellidoPaterno;
ApellidoMaterno = myApellidoMaterno;
Edad = myEdad;
}
//metodos
public int GetCarnet(){
    return carnet;
}
public void SetCarnet(int myCarnet){
    carnet = myCarnet;
}
public int GetCodigoEstudiante(){
    return CodigoEstudiante;
}
public void SetCodigoEstudiante( int myCodigoEstudiante){
    CodigoEstudiante = myCodigoEstudiante;
}
public string GetNombre(){
    return Nombre;
}
public void SetNombre(string myNombre){
    Nombre = myNombre;
}
public string GetApellidopaterno(string myApellidoPaterno){
    return ApellidoPaterno;

}
public void SetApellidoPaterno(string myApellidoPaterno){
ApellidoPaterno = myApellidoPaterno;
}
public string GetApellidoMaterno(string myApellidoMaterno){
    return ApellidoMaterno;

}
public void SetApellidoMaterno(string myApellidoMaterno){
ApellidoMaterno = myApellidoMaterno;
}
public int GetEdad(int myEdad){
    return Edad;
}
public void SetEdad(int myEdad){
    Edad = myEdad;
}

}