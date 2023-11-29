using System;
using System.IO;

public class Fichero
{
    //-----------------UBICACION DEL ARCHIVO O FICHERO
    public string path;
    //-----------------CONSTRUCTOR VACIO
    public Fichero()
    {
        path = "";
    }
    //-----------------EL CONSTRUCTOR CON PARAMETROS
    public Fichero(string mypath)
    {
        path = mypath;
    }
    //-----------------ESCRIBE TODO EL CONTENIDO EN EL ARCHIVO
    public void WriteAllText(string path, string contenido)
    {
        File.WriteAllText(path, contenido);
    }
    //-----------------Escribe las lineas en el archivo
     public void WriteLine(string path, string[] lineas)
    {
        File.WriteAllLines(path, lineas);
    }
    //-----------------ECTURA DE TODO EL ARCHIVO
    public string ReadAllText(string path)
    {
        if (File.Exists(path))
        {
            string readTex = File.ReadAllText(path);
            return readTex;
        }
        return "El archivo no existe Path: " + path;
    }
    //-----------------LECTURA DE LINEA POR LINEA DEL ARCHIVO
    public void ReadAllLines(string path)
    {
        if (File.Exists(path))
        {
            string[] lineas = File.ReadAllLines(path);
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }else
    {
        Console.WriteLine("El archivo no existe Path: " + path);
    }
        
    }
     public string[] ReadAllLinesV2(string path)
    {
        return File.ReadAllLines(path);
    }
}