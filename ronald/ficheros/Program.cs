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

            string path1 = "D:/GitHub/PRO2-UPC/DOCENTE/ficheros/" + e1.GetNombre() + ".txt";
            string path2 = "D:/GitHub/PRO2-UPC/DOCENTE/ficheros/" + e2.GetNombre() + ".txt";

            f.WriteLine(path1, student1);
            f.WriteLine(path2, student2);

            string[] estudianteFichero = f.ReadAllLinesV2(path1);
            Estudiante e3 = new Estudiante();
            e3.ArrayToEstudiante(estudianteFichero);
            e3.Mostrar();
            */
            /*
            for(int i = 10; i<=20; i = i + 10){
                CrearArchivos(i+"", i);
            }
            */

            /*
            //Genera un archivo txt 
            string path = "E:/USis/ProgramII/PRO2-UPC/ronald/ficheros/for/fichero1.txt";
            FicheroRonald fd = new FicheroRonald(path);
            fd.EscribirTexto("hola mundo");

            
            //Genera un archivo array
            fd.path="E:/USis/ProgramII/PRO2-UPC/ronald/ficheros/for/fichero2.txt";
            string[] arrayRonald = {"hola" , "mundo"};
            fd.EscribirArray(arrayRonald);
            */
            /*
            //Genera una serie iterativa
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamen(cant);
            AC.MostrarArray();
            */

            /*
            //Genra una serie recursiva
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamenRecursivo(true, 1, 2, cant);
            AC.MostrarArray();
            

            
            //Crea el fichero donde estara la serie
            string path = "E:/USis/ProgramII/PRO2-UPC/ronald/ficheros/for/ficheroArray.txt";
            FicheroRonald fd = new FicheroRonald(path);
            fd.EscribirArray(resultadoSerie);
            //Console.WriteLine();
            */

        
            //Genera una serie Factorial
            for(int a = 0; a<20;a++){
            
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            long res =  AC.FactorialRecursivo(cant);
            //Console.WriteLine("res: " + res);
            AC.MostrarArray();
            
            
            string path = "E:/USis/ProgramII/PRO2-UPC/ronald/ficheros/for/FactorialRecursivo" + a + ".txt";
            FicheroRonald fd = new FicheroRonald(path);
            fd.EscribirArray(AC.ArrayCadenas);
            
            }

            /*
            //Factorial Iterativo
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            long res =  AC.FactorialIterativo(cant);
            //Console.WriteLine("res: " + res);
            AC.MostrarArray();
            */
            //Console.WriteLine();
        }











        /*
        public static void CrearArchivos(string subFolder, int cant){    
            DateTime timeInicio = DateTime.Now;
            //Console.WriteLine("Inicio: " + timeInicio);
            Fichero f =  new Fichero();
            for(int i = 1; i<=cant;i++){               
                string pathFor = "E:/USis/ProgramII/PRO2-UPC/ronald/ficheros/for/" + subFolder;
                bool exists = Directory.Exists(pathFor);

                if(!exists){
                    Directory.CreateDirectory(pathFor);
                }    

                Estudiante e = new Estudiante(9775810, 2023, 
                "Douglas ", "Carrasco ", "Cruz", 19);
                
                string[] arrayEstudiante = e.EstudianteToArray();

                pathFor = pathFor + "/" + i + ".txt";
                Console.WriteLine(pathFor);
                f.WriteLine(pathFor, arrayEstudiante);
            }
            DateTime timeFin = DateTime.Now;
            //Console.WriteLine("Fin: " + timeFin);
            
            Console.WriteLine("Total: " + "(" + cant + ") " + timeFin.Subtract(timeInicio));   
        }
        */
    }
}