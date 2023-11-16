﻿public class Estudiante{
    //Las Propiedades
   public int Id;
   public string NombreCompleto;
   public int Carnet;
   public string Genero; 
   public int Edad;
    //El Constructor (procedimiento por defecto, que se ejecuta la primera vez)
    public Estudiante(){
        Id = 2;
        NombreCompleto = "Danny Carita";
        Carnet  = 12921159;
        Genero = "Masculino";
        Edad = 23;
    }
    public string Mostrar(){
        return "Estudiante: { Id: " + Id + ", " +
        "NombreCompleto: " + NombreCompleto + ", " +
        "Carnet: " + Carnet + ", " +
        "Genero: " + Genero + ", " +
        "Edad: " + Edad + "}";
    }
}











