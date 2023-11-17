using System;

namespace Universidad
{
    public class Inscrito
    {
        public Inscrito(int id, string fecha, int idEstudiante, int idMateria)
        {
            Id = id;
            Fecha = fecha;
            IdEstudiante = idEstudiante;
            IdMateria = idMateria;
        }

        public int Id { get; set; }
        public string Fecha { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Inscrito ID: {Id}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"ID Estudiante: {IdEstudiante}");
            Console.WriteLine($"ID Materia: {IdMateria}");
            Console.WriteLine();
        }
    }
}
