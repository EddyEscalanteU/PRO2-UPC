public class FicheroSoto{
    public string path;

    public FicheroSoto(string myPath){
        path = myPath;
    }
    //ESCRIBIR
    public void EscribirTexto(string txt){
        File.WriteAllText(path,txt);
    }
    public void EscribirArray(string[] array){
        File.WriteAllLines(path,array);
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
        }else{
            Console.WriteLine("El archivo no existe Path: " + path);
        }
    }
}