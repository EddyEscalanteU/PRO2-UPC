﻿using System.Reflection.Metadata;

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
  
            string path1 = "C:/Users/amzed/OneDrive/Escritorio/rojA" + e1.GetNombre() + ".txt";
            string path2 = "C:/Users/amzed/OneDrive/Escritorio/rojA" + e2.GetNombre() + ".txt";

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
            string path = "C:/Users/amzed/OneDrive/Escritorio/rojA.txt";
            EliasRojas fd = new EliasRojas(path);
            fd.EscribirTexto("hola mundo");
            fd.path="C:/Users/amzed/OneDrive/Escritorio/rojA.txt";
            string[] arrayEmilio = {"hola" , "mundo"};
            fd.EscribirArray(arrayEmilio);
            */
            /*
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamenRecursivo(true, 1, 2, cant);
            AC.MostrarArray();
        

        string path = "C:/Users/amzed/OneDrive/Escritorio/rojA";
        EliasRojas fd = new EliasRojas(path);
            fd.EscribirArray(resultadoSerie);
            */
            /*
        for(int a = 0; a<20;a++){
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            long res =  AC.Factorial(cant);
            //Console.WriteLine("res: " + res);
            AC.MostrarArray();
            
            string path = "D:/emilio/FactorialArchivo" + a + ".txt";
            EliasRojas fd = new EliasRojas(path);
            fd.EscribirArray(AC.ArrayCadenas);
                
            }
            */
            //Console.WriteLine();
        }
            
        public static void CrearArchivos(string subFolder, int cant){    
            DateTime timeInicio = DateTime.Now;
            //Console.WriteLine("Inicio: " + timeInicio);
            Fichero f =  new Fichero();
            for(int i = 1; i<=cant;i++){               
                string pathFor = "C:/Users/amzed/OneDrive/Escritorio/rojA" + subFolder;
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