
public class Ficherodouglas
{
    //La ubicacion del archivo o fichero
    public string path;
    //el constructor
    public Ficherodouglas()
    {
        path = "";
    }
    public Ficherodouglas(string myPath)
    {
        path = myPath;
    }
    //Escribir todo el contenido en el archivo
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
    public string ReaAllText(string path){
        if (File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            return readText;
        }
        return "El archivo no existe Patch:" + path;
    }
    //lectura de la linea por linea del archivo
    public void ReaAllLines(string path)
    {
        if (File.Exists(path))
        {
            string[] lineas = File.ReadAllLines(path);
            foreach (string linea in lineas){
                Console.WriteLine(linea);
            }
        }
    else{
        Console.WriteLine("El archivo no existe Path:" + path);
    }
    
}

    public string[] ReadAllLinesV2(string path)
    {
        return File.ReadAllLines(path);
    }
}
