namespace ProgramacionDos{
    public class Program{
        public static void Main(string[] args)
        {
            /*
            Estudiante e1 = new Estudiante(13032202, 13032202, 
            "Jasseph", "Del Castillo", "Ferrufino", 21);

            Estudiante e2 = new Estudiante(14274252, 14274252, 
            "The Bryan", "Carrasco", "Cruz", 19);

            e1.Mostrar();
            e2.Mostrar();
            */
            string path = "D:/GitHub/PRO2-UPC/DOCENTE/ficheros/archivo.txt";
            Fichero f =  new Fichero(path);

            //string texto = f.ReadAllText(path);
            //Console.WriteLine(texto);

            //f.ReadAllLines(path);

            Estudiante e1 = new Estudiante(13032202, 13032202, 
            "Jasseph", "Del Castillo", "Ferrufino", 21);

            string nombreCompleto = e1.GetNombre() +
                                    " " + e1.GetApellidoPaterno() +
                                    " " + e1.GetApellidoMaterno();

            //f.WriteAllText(path, nombreCompleto);
             string[] textLines = { "This is the first line",  
                               "This is the second line", 
                              "This is the third line" }; 
  
            f.WriteLine(path, textLines);
        }
    }
}
