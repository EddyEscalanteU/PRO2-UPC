using System;
using System.IO;
public class Fichero
{
    // La ubicacion del archivo o Fichero
    public string path;
    //El constructor vaio
    public Fichero()
    {
        path = "";
    }
    // El contructor con parametro
    public Fichero(string myPath)
    {
        path = myPath;
    }
    //Escribe todo el contenido del archivo
    public void WriteAllText(string path, string contenido)
    {
        File.WriteAllText(path, contenido);
    }
    public void WriteLine(string path, string [] lineas)
    {
        File.WriteAllLines(path, lineas);
    }
    // Lectura todo el archivo
    public string ReadAllText(string path)
    {
        if (File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            return readText;
        }
        return "El archivo no existe Path" + path;
    }
    // lectura linea po linea del archivo
    public void ReadAllLines(string path)
    {
        if (File.Exists(path))
        {
            string[] lineas = File.ReadAllLines(path);
            foreach (string ln in lineas)
            {
                // Console.WriteLine("line: ");

                Console.WriteLine(lineas);
            }
        } else {Console.WriteLine("El archivo no existe Patn: " + path);
         }       
    }
     public string[] ReadAllLinesV2(string path)
    {
        return File.ReadAllLines(path);
    }
}
