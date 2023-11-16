using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Materia
    {
        public int Id;
        public string Nombre;
        public string Abreviatura;
        public int Capacidad;

        public Materia()
        {
            Id = 0;
            Nombre = "Programacion II";
            Abreviatura = "Program";
            Capacidad = 0;
        }
        public void DarNombre(string valor)
        {
            Nombre = valor;
        }

        public void AsignarAbreviatura(string valor)
        {
            Abreviatura = valor;
        }
        public string Mostrar()
        {
            return "Materia: Id: " + Id + ", " +
            "Nombre de la Materia: " + Nombre + ", " +
            "Abreviatura: " + Abreviatura + ", " +
            "Capacidad: " + Capacidad + ", ";
        }
    }
}
