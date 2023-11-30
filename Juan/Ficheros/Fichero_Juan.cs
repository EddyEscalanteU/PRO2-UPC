public class Fichero_Juan{
    //-----------------UBICACION DEL ARCHIVO O FICHERO
    public string ruta;
    //-----------------CONSTRUCTOR VACIO
    public Fichero_Juan()
    {
        ruta = "";
    }
    //-----------------EL CONSTRUCTOR CON PARAMETROS
    public Fichero_Juan(string miRuta)
    {
        ruta = miRuta;
    }
    //-----------------ESCRIBE TODO EL CONTENIDO EN EL ARCHIVO
    public void EscribirTodoTexto(string txt)
    {
        File.WriteAllText(ruta, txt);
    }
    //-----------------Escribe las lineas en el archivo
     public void EscribirArray(string[] array)
    {
        File.WriteAllLines(ruta, array);
    }
    //-----------------LECTURA DE TODO EL ARCHIVO
    public string LeerTodoTexto(string ruta)
    {
        if (File.Exists(ruta))
        {
            string textoLeido = File.ReadAllText(ruta);
            return textoLeido;
        }
        return "El archivo no existe. Ruta: " + ruta;
    }
    //-----------------LECTURA DE LINEA POR LINEA DEL ARCHIVO
    public void LeerArray()
    {
        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe. Ruta: " + ruta);
        }
    }
}