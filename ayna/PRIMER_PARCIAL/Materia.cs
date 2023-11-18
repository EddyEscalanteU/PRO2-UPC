using System;

namespace Universidad
{
    public class Materia
    {
        public Materia(int id, string nombre, string abreviatura, int capacidad)
        {
            Id = id;
            Nombre = nombre;
            Abreviatura = abreviatura;
            Capacidad = capacidad;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public int Capacidad { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Materia ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Abreviatura: {Abreviatura}");
            Console.WriteLine($"Capacidad: {Capacidad}");
            Console.WriteLine();
        }
    }
}
