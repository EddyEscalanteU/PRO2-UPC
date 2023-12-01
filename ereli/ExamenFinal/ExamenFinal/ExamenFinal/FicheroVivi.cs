using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FicheroVivi
    {
    public string path;

    public FicheroVivi(string myPath)
    {
        path = myPath;
    }
    //ESCRIBIR
    public void EscribirTexto(string txt)
    {
        File.WriteAllText(txt, path);
    }
    public void EscribirArray(string[] array)
    {
        File.WriteAllLines(path, array);
    }
    //LEER
    public string LeerArchivo()
    {
        if (File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            return readText;
        }
        return "El archivo no existe Path: " + path;
    }

    public void LeerArchivoArray()
    {
        if (File.Exists(path))
        {
            string[] lineas = File.ReadAllLines(path);

            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe Path: " + path);
        }
    }
}
