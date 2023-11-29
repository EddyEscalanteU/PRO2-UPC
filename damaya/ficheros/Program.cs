﻿namespace ProgramacionDos{
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
            //string path = "C:/Users/alumno/Documents/d/PRO2-UPC/damaya/ficheros/archivo.txt";
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
            
            
            Estudiante e1 = new Estudiante(9829276, 9829276, 
            "Diego", "Amaya", "Quispe", 21);

            Estudiante e2 = new Estudiante(14274252, 14274252, 
            "Bryan", "Carrasco", "Cruz", 19);

            string[] student1 = e1.EstudianteToArray();
            string[] student2 = e2.EstudianteToArray();
  
            string path1 = "C:/Users/alumno/Documents/d/PRO2-UPC/damaya/ficheros/" + e1.GetNombre() + ".txt";
            string path2 = "C:/Users/alumno/Documents/d/PRO2-UPC/damaya/ficheros/" + e2.GetNombre() + ".txt";

            f.WriteLine(path1, student1);
            f.WriteLine(path2, student2);

            string[] estudianteFichero = f.ReadAllLinesV2(path1);
            Estudiante e3 = new Estudiante();
            e3.ArrayToEstudiante(estudianteFichero);
            e3.Mostrar();*/

            DateTime timeInicio = DateTime.Now;
            Console.WriteLine("Inicio: " + timeInicio);
            Fichero f =  new Fichero();
            for(int i = 1; i <=10000; i++){
                Estudiante e = new Estudiante(9829276, 9829276, 
            "Diego", "Amaya", "Quispe", 21);

            string[] arrayEstudiante = e.EstudianteToArray();

            string pathFor = "C:/Users/alumno/Documents/d/PRO2-UPC/damaya/ficheros/For/" + i + ".txt";

            f.WriteLine(pathFor, arrayEstudiante);
            }
             DateTime timeFin = DateTime.Now;
            Console.WriteLine("Fin: " + timeFin);

            Console.WriteLine("Total: " + timeFin.Subtract(timeInicio));
        }
    }
}
