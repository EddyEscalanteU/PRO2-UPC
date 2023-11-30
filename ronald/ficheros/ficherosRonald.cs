public class FicheroRonald{
    public string path;

    public FicheroRonald(string myPath){
        path = myPath;
    }
    //Escribir archivos
    public void EscribirTexto(string txt){
        File.WriteAllText(path,txt);
    }
    public void EscribirArray(string[] array){
        File.WriteAllLines(path,array);
    }
    //Lectura de todo el archivo
    public string LeerArchivo()
    {
        if (File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            return readText;
        }
        return "El archivo no existe Path: " + path;
    }
    //Lectura de linea por linea del archivo
    public void LeerArchivoArray()
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