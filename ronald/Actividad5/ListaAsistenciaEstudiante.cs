using System;

namespace Practica2
{
    public class ListaAsistenciaEstudiantes
    {
        public string Grupo { get; set; }
        public string Materia { get; set; }
        public string Docente { get; set; }
        public string Periodo { get; set; }
        public string Hora { get; set; }

        public ListaAsistenciaEstudiantes()
        {
            Grupo = "Sin Grupo";
            Materia = "Sin Materia";
            Docente = "Sin Docente";
            Periodo = "Sin Periodo";
            Hora = "Sin Hora";
        }

        public string Mostrar()
        {
            return "Lista de Asistencia de Estudiantes: {" +
                   "Grupo: " + Grupo + ", " +
                   "Materia: " + Materia + ", " +
                   "Docente: " + Docente + ", " +
                   "Periodo: " + Periodo + ", " +
                   "Hora: " + Hora + "}";
        }
    }
}
