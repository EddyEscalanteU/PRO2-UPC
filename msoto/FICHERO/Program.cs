namespace ProgramacionDos{
    public class Program{
        public static void Main(string[] args)
        {
           /* Estudiante e1 =new Estudiante(5412367,54123670, "Jennifer", "Morales", "Saucedo", 18);
            Estudiante e2 =new Estudiante(12654783,126547835, "Marilin", "Avila", "Carrasco", 21);
            e1.Mostrar();
            e2.Mostrar(); */

            //string path = "D:/MSOTO/GitHub/PRO2-UPC/msoto/FICHERO/archivo.txt";
            //Fichero f = new Fichero(path);

            //string texto = f.ReadAllText(path);
            //Console.WriteLine(texto);

            //f.ReadAllLines(path);

            //f.WriteAllText(path,nombreCompleto);

           /* 
            Estudiante e1 = new Estudiante( 9769742, 9769742*, "Maria", "Soto", "Zanabria", 0);

            string[] student = e1.EstudianteToArray();
            f.WriteLine(path, student);
            */

            /*
            Estudiante e1 = new Estudiante(13032202, 13032202, 
            "Jasseph", "Del Castillo", "Ferrufino", 21);

            Estudiante e2 = new Estudiante(14274252, 14274252, 
            "Bryan", "Carrasco", "Cruz", 19);

            string[] student1 = e1.EstudianteToArray();
            string[] student2 = e2.EstudianteToArray();
  
            string path1 = "D:/MSOTO/GitHub/PRO2-UPC/msoto/FICHERO/" + e1.GetNombre() + ".txt";
            string path2 = "D:/MSOTO/GitHub/PRO2-UPC/msoto/FICHERO/" + e2.GetNombre() + ".txt";

            f.WriteLine(path1, student1);
            f.WriteLine(path2, student2);  

            string[] estudianteFichero = f.ReadAllLinesV2(path1);
            Estudiante e3 = new Estudiante();
            e3.ArrayToEstudiante(estudianteFichero);
            e3.Mostrar();
            */

            /* for(int i = 1000; i<=50000; i = i + 1000){
                CrearArchivos(i+"", i);
            }
            */
            /*
            string path = "C:/Users/usuario/Desktop/UPC/PROGRAMACION ll/PRO2-UPC/msoto/FICHEROS/fichero1.txt";
            FicheroSoto fd = new FicheroSoto(path);
            fd.EscribirTexto("HOLA GENIO");
            fd.path="C:/Users/usuario/Desktop/UPC/PROGRAMACION ll/PRO2-UPC/msoto/FICHEROS/fichero2.txt";
            string[] arraySoto = {"HOLA" , "GENIO"};
            fd.EscribirArray(arraySoto);
            */
            /*
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamenRecursivo(true, 1, 2, cant);
            AC.MostrarArray();

            string path = "C:/Users/usuario/Desktop/UPC/PROGRAMACION ll/PRO2-UPC/msoto/FICHEROS/ficheroArray.txt";
            FicheroSoto fd = new FicheroSoto(path);
            fd.EscribirArray(resultadoSerie);
            //Console.WriteLine();
            */

            
            for(int a = 0; a<20;a++){
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            long res =  AC.Factorial(cant);
            //Console.WriteLine("res: " + res);
            AC.MostrarArray();
            
            string path = "C:/Users/usuario/Desktop/UPC/PROGRAMACION ll/PRO2-UPC/msoto/FICHEROS/FactorialArchivo" + a + ".txt";
            FicheroSoto fd = new FicheroSoto(path);
            fd.EscribirArray(AC.ArrayCadenas);
                
            }
            
            //Console.WriteLine();
        

        }




            

           DateTime timeInicio = DateTime.Now;
            Console.WriteLine("Inicio: " + timeInicio);
            Fichero f =  new Fichero();
            for(int i = 1; i<=10000;i++){
                Estudiante e = new Estudiante(9775810, 2023, 
                "Maria", "Soto", "Zanabria", 0);
                
                string[] arrayEstudiante = e.EstudianteToArray();

                string pathFor = "D:/MSOTO/GitHub/PRO2-UPC/msoto/FICHERO/for/" + i + ".txt";
                f.WriteLine(pathFor, arrayEstudiante);
            }
            DateTime timeFin = DateTime.Now;
            Console.WriteLine("Fin: " + timeFin);
            
            Console.WriteLine("Total: " + timeFin.Subtract(timeInicio));

        }
    }
}
