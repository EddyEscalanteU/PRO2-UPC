using System;
using System.IO;

public class Fichero
{
    //La ubicación del archivo o fichero
    public string path;

    //El constructor vacio
    public Fichero()
    {
        path = "";
    }

    //El contructor con parametro
    public Fichero(string myPath)
    {
        path = myPath;
    }

    //Escribe todo el contenido en el archivo
    public void WriteAllText(string path, string contenido)
    {
        File.WriteAllText(path, contenido);
    }

    //Escribe las lineas en el archivo
    public void WriteLine(string path, string[] lineas)
    {
        File.WriteAllLines(path, lineas);
    }

    //Lectura de todo el archivo
    public string ReadAllText(string path)
    {
        if (File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            return readText;
        }
        return "El archivo no existe Path: " + path;
    }

    //Lectura de linea por linea del archivo
    public void ReadAllLines(string path)
    {
        if (File.Exists(path))
        {
            string[] lineas = File.ReadAllLines(path);

            foreach (string linea in lineas)
            {
                //Console.WriteLine("Line:");
                Console.WriteLine(linea);
            }
        }else{
            Console.WriteLine("El archivo no existe Path: " + path);
        }
    }
}
