using System;

namespace Universidad
{
    public class Estudiante
    {
        public Estudiante(int id, string nombreCompleto, int carnet, string genero, int edad)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            Carnet = carnet;
            Genero = genero;
            Edad = edad;
        }

        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int Carnet { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Estudiante ID: {Id}");
            Console.WriteLine($"Nombre Completo: {NombreCompleto}");
            Console.WriteLine($"Carnet: {Carnet}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine();
        }
    }
}
