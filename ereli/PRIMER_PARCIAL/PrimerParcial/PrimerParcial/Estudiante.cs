using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Estudiante
    {
        public int Id;
        public string NombreCompleto;
        public int Carnet;
        public string Genero;
        public int Edad;

        public Estudiante()
        {
            Id = 0;
            NombreCompleto = "Sin Nombre";
            Carnet = 0;
            Genero = "Por determinar";
            Edad = 0;
        }
        public Estudiante(int ci, string name, int myEdad)
        {
            Id = 1234;
            NombreCompleto = name;
            Carnet = ci;
            Genero = " ";
            Edad = myEdad;
        }
        public string Mostrar()
        {
            return "Estudiante.- Id: " + Id + ", " +
            "Nombre Completo: " + NombreCompleto + ", " +
            "Carnet: " + Carnet + ", " +
            "Genero: " + Genero + ", " +
            "Edad: " + Edad + ", ";
        }
    }
}
