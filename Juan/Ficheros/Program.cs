namespace programacion2
{
    public class Program{
        public static void Main(string[]args){
           /* Estudiante el = new Estudiante(8888717, 8888717, "Juan Pablo", "Tapeosid", "Chamo", 21);
            el.Mostrar();
            Estudiante e2 = new Estudiante(14274252, 14274252, 
            "The Bryan", "Carrasco", "Cruz", 19);

            e1.Mostrar();
            e2.Mostrar();*/
            //string path = "c:/PRO2-UPC/PRO2-UPC/Juan/Ficheros/archivo.txt";
            //Fichero f = new Fichero(path);

            //string texto = f.ReadAllText(path);
            //Console.WriteLine(texto);
            //f.ReadAllLines(path);
            //Estudiante el = new Estudiante(8888717, 8888717, "Juan Pablo", "Tapeosi", "Chamo", 21);
            //string[] student = el.EstudianteToArray();
            
            /*string nombreCompleto = el.GetCarnet() + 
                                 " " + el.GetCodigoEstudiante() + 
                                " " + el.GetNombre() +
                                " " + el.GetApellidoPaterno() +                             
                                " " + el.GetApellidoMaterno() +
                                " " + el.GetEdad();*/
            //f.WriteAllText(path, nombreCompleto);
            /*string[] textLines = { "This is the first line",  
                               "This is the second line", 
                              "This is the third line" }; */
  
            //.WriteLine(path, textLines);
            //f.WriteLine(path, student );
            
/*
            string[] estudianteArchivo = f.ReadAllLinesV2(path);
            Estudiante e1 = new Estudiante();
            e1.ArrayToEstudiante(estudianteArchivo);
            e1.Mostrar();
            */
            /*Estudiante e1 = new Estudiante(8888717, 8888717, 
            "Juan Pablo", "Tapeosi", "Chamo", 21);

            Estudiante e2 = new Estudiante(1321231, 5161123, 
            "Miguel", "Rios", "Padilla", 19);

            string[] student1 = e1.EstudianteToArray();
            string[] student2 = e2.EstudianteToArray();
  
            string path1 = "c:/PRO2-UPC/PRO2-UPC/Juan/Ficheros/" + e1.GetNombre() + ".txt";
            string path2 = "c:/PRO2-UPC/PRO2-UPC/Juan/Ficheros/" + e2.GetNombre() + ".txt";

            f.WriteLine(path1, student1);
            f.WriteLine(path2, student2);

            string[] estudianteFichero = f.ReadAllLinesV2(path1);
            Estudiante e3 = new Estudiante();
            e3.ArrayToEstudiante(estudianteFichero);
            e3.Mostrar();*/
            /*DateTime timeInicio = DateTime.Now;
            Console.WriteLine("Inicio: " + timeInicio);
            Fichero f =  new Fichero();
            for(int i = 1; i<=100000;i++){
                Estudiante e = new Estudiante(9775810, 2023, 
                "Douglas ", "Carrasco ", " Cruz", 19);
                
                string[] arrayEstudiante = e.EstudianteToArray();

                string pathFor = "c:/PRO2-UPC/PRO2-UPC/Juan/Ficheros/for/" + i + ".txt";
                f.WriteLine(pathFor, arrayEstudiante);
            }
            DateTime timeFin = DateTime.Now;
            Console.WriteLine("Fin: " + timeFin);
            
            Console.WriteLine("Total: " + timeFin.Subtract(timeInicio));*/
        /*for(int i = 1000; i<=2000; i = i + 1000){
                CrearArchivos(i+"", i);
            }*/
            /*string path = "C:/juan/fichero.txt";
            Fichero_Juan d = new Fichero_Juan(path);
            d.EscribirTodoTexto("hola mundo");
            d.path = "C:/juan/fichero.txt";
            string [] arrayjuan = { "hola", " mundo"};
            d.EscribirArray(arrayjuan);*/
            /*int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultado = AC.GenerarSerieExamen(cant);
            AC.MostrarArray();

            string path = "C:/juan/fichero.txt";
            Fichero_Juan d = new Fichero_Juan(path);
            d.EscribirArray(resultado);*/

            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            long res =  AC.Factorial(cant);
            //Console.WriteLine("res: " + res);
            AC.MostrarArray();

            string path = "C:/juan/Factorialfichero.txt";
            Fichero_Juan d = new Fichero_Juan(path);
            d.EscribirArray(AC.ArrayCadenas);

        }







        public static void CrearArchivos(string subFolder, int cant){    
            DateTime timeInicio = DateTime.Now;
            //Console.WriteLine("Inicio: " + timeInicio);
            Fichero f =  new Fichero();
            for(int i = 1; i<=cant;i++){               
                string pathFor = "c:/PRO2-UPC/PRO2-UPC/Juan/Ficheros/for/" + subFolder;
                bool exists = Directory.Exists(pathFor);

                if(!exists){
                    Directory.CreateDirectory(pathFor);
                }    

                Estudiante e = new Estudiante(9775810, 2023, 
                "Douglas ", "Carrasco ", " Cruz", 19);
                
                string[] arrayEstudiante = e.EstudianteToArray();

                pathFor = pathFor + "/" + i + ".txt";
                Console.WriteLine(pathFor);
                f.WriteLine(pathFor, arrayEstudiante);
            }
            DateTime timeFin = DateTime.Now;
            //Console.WriteLine("Fin: " + timeFin);
            
            Console.WriteLine("Total: " + "(" + cant + ") " + timeFin.Subtract(timeInicio));
        }
    }
}