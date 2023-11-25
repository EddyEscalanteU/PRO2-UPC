﻿public class Materia{
    public int Id;
    public string Nombre;
    public string Abreviatura;
    public int Capacidad;
    public Materia(){
        Id = ;
        Nombre = "Ing. EDDY ESCALANTE USTARIZ";
        Abreviatura = "PRO 2";
        Capacidad = 34;
    }
    public Materia(int MyId, string MyNombre, string MyAbreviatura, int MyCapacidad){    
        Id = MyId;
        Nombre = MyNombre;
        Abreviatura = MyAbreviatura;
        Capacidad = MyCapacidad;
    }

    public string Mostrar(){
        return "Materia { Id: " + Id + ", " +
        "Nombre: " + Nombre + ", " +
        "Abreviatura: " + Abreviatura + ", " +
        "Capacidad: " + Capacidad + " }";

    }
}
















