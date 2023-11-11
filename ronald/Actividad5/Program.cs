using System;

namespace Practica2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListaAsistenciaEstudiantes listaAsistencia = new ListaAsistenciaEstudiantes();
            Console.WriteLine(listaAsistencia.Mostrar());

            // Modificar propiedades de la lista de asistencia
            listaAsistencia.Grupo = "Grupo A";
            listaAsistencia.Materia = "Matemáticas";
            listaAsistencia.Docente = "Profesor Smith";
            listaAsistencia.Periodo = "2023-1";
            listaAsistencia.Hora = "10:00 AM";

            // Mostrar la información actualizada de la lista de asistencia
            Console.WriteLine(listaAsistencia.Mostrar());
        }
    }
}