using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Inscrito
    {
        public int Id;
        public int Fecha;
        public Estudiante Estudiante;
        public Materia Materia;

        public Inscrito()
        {
            Id = 0;
            Fecha = 15/11/2023;
            Estudiante = new Estudiante();
            Materia = new Materia();
        }

        public string Mostrar()
        {
            return "Inscripcion.- Id: " + Id + ", " +
            "Fecha: " + Fecha + ", " +
            "IdEstudiante: " + Estudiante.Mostrar() + ", " +
            "Materia.- " + Materia.Mostrar()+ "}";
        }
    }

}
