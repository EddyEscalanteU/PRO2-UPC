﻿using System; 
using System.IO; 

namespace ProgramacionDos{
    public class Program{
        public static void Main(string[] args)
        {
            /*
            Estudiante e1 = new Estudiante(13032202, 13032202, "Jasseph", "Del Castillo", "Ferrufino", 21);

            Estudiante e2 = new Estudiante(14274252, 14274252, "The Bryan", "Carrasco", "Cruz", 19);

            e1.Mostrar();
            e2.Mostrar();
            */
            string path = "D:/GitHub/PRO2-UPC/DOCENTE/ficheros/archivo.txt";
            //string createText = "Hello and Welcome";
            //File.WriteAllText(path, createText);

            string readText = File.ReadAllText(path);

            Console.WriteLine(readText);
        }
    }
}