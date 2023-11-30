public class FicheroAmaya{
    public string path;

    public FicheroAmaya(string myPath){
        path = myPath;
    }    

    public void EscribirTexto(string texto){
        File.WriteAllText(path, texto);
    }
    public void EscribirArray(string[] array){
        File.WriteAllLines(path, array);
    }
    public string LeerArchivo()
    {
        if (File.Exists(path))
        {
            string readText = File.ReadAllText(path);
            return readText;
        }
        return "El archivo no existe Path: " + path;
    }
    public void LeerArchivoArray(){
        if (File.Exists(path))
        {
            string[] lineas = File.ReadAllLines(path);

            foreach (string linea in lineas)
            {
             //Console.WriteAllLine(linea);
            }
        }else{
           //Console.WriteAllLine("El archivo no existe Path:" + path);
        }
    }
}