using System.Reflection.Metadata;

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
            //string path = "D:/GitHub/PRO2-UPC/DOCENTE/ficheros/archivo.txt";
            //Fichero f =  new Fichero(path);

            //string texto = f.ReadAllText(path);
            //Console.WriteLine(texto);

            //f.ReadAllLines(path);

            //f.WriteAllText(path, nombreCompleto);

            /*
            Estudiante e1 = new Estudiante(14274252, 2023, 
            "The Bryan", "Carrasco", "Cruz", 19);

            string[] student = e1.EstudianteToArray();
  
            f.WriteLine(path, student);

            */
/*
            string[] estudianteArchivo = f.ReadAllLinesV2(path);
            Estudiante e1 = new Estudiante();
            e1.ArrayToEstudiante(estudianteArchivo);
            e1.Mostrar();
            */
            /*
            Estudiante e1 = new Estudiante(13032202, 13032202, 
            "Jasseph", "Del Castillo", "Ferrufino", 21);

            Estudiante e2 = new Estudiante(14274252, 14274252, 
            "Bryan", "Carrasco", "Cruz", 19);

            string[] student1 = e1.EstudianteToArray();
            string[] student2 = e2.EstudianteToArray();
  
            string path1 = "C:/UPC/PRO2-UPC/jsoto/Fillero" + e1.GetNombre() + ".txt";
            string path2 = "C:/UPC/PRO2-UPC/jsoto/Fillero" + e2.GetNombre() + ".txt";

            f.WriteLine(path1, student1);
            f.WriteLine(path2, student2);

            string[] estudianteFichero = f.ReadAllLinesV2(path1);
            Estudiante e3 = new Estudiante ();
            e3.ArrayToEstudiante(estudianteFichero);
            e3.Mostrar();*/

            /*******************************************************     
            *genera archivos txt con informacion en forma de blucle*
            *******************************************************/

            /*DateTime timeInicio = DateTime.Now;
            Console.WriteLine("Inicio: " + timeInicio);
            Fichero f = new Fichero();
            for(int i = 1; i<= 20000; i++){
                Estudiante e = new Estudiante(9775810, 2023, "Doglas ", "Carrasco", "Cruz", 19);
                
                string[]arrayEstudiante = e.EstudianteToArray();
                string pathFor = "C:/UPC/PRO2-UPC/jsoto/Fillero/for/" + i  + "txt";
                f.WriteLine(pathFor, arrayEstudiante);
            }
            DateTime timeFin = DateTime.Now;
            Console.WriteLine("Fin: " + timeFin);

            Console.WriteLine("Total: " + timeFin.Subtract(timeInicio));*/
            
            /*
            string path = "C:/UPC/PRO2-UPC/jsoto/Fillero1.txt";
            FicheroJoelSoto fd = new FicheroJoelSoto (path);
            fd.EscribirTexto("Angel mide 1.82");
            fd.path = "C:/UPC/PRO2-UPC/jsoto/Fillero2.txt";
            string[] arrayAnegel = {"hola" ,  " mundo"}; */

            int cant = 10; 
            ClaseArreyCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamen(cant);
            AC.MostrarArray();}

            string path = "";
            FicheroJoelSoto fd = new FicheroJoelSoto(path);
            FieldDefinition.EscribirArray(resultadoSerie);


        
    }   
}       