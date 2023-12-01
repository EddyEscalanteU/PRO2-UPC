using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Examen Final");
            //PREGUNTA RECURSIVO TO ITERATIVO
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamenFinal(cant);
            AC.MostrarArray();

            string path = "C:\\UPC\\PRO2-UPC-HOMEWORK\\ExamenFinal\\SerieIterativo.txt";
            FicheroVivi fa = new FicheroVivi(path);
            fa.EscribirArray(AC.ArrayCadenas);



            DateTime timeInicio = DateTime.Now;
            Console.WriteLine("Inicio: " + timeInicio);
            Fichero f = new Fichero();

            for (int i = 1; i <= 15; i++)
            {
               
                ClaseArrayCadenas e = new ClaseArrayCadenas(cant);

                string[] arrayExamen = e.GenerarSerieExamenFinal(cant);

                string pathFor = "C:\\UPC\\PRO2-UPC-HOMEWORK\\ExamenFinal\\for\\" + i + ".txt";
                f.WriteLine(pathFor, arrayExamen);
            }
            DateTime timeFin = DateTime.Now;
            Console.WriteLine("Fin: " + timeFin);

            Console.WriteLine("Total: " + timeFin.Subtract(timeInicio));

        }
    }
}