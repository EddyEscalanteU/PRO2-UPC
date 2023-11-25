using System;

namespace Universidad
{
    class Program
    {
        static void Main()
        {
            // Crear instancias de las clases utilizando constructores
            Estudiante estudiante = new Estudiante(1, "Nelson Ayna", 20210001, "Masculino", 20);

            Inscrito inscrito = new Inscrito(1, "2023-01-01", estudiante.Id, 101);

            Materia materia = new Materia(101, "Programación", "Prog", 30);

            // Mostrar información
            estudiante.Mostrar();
            inscrito.Mostrar();
            materia.Mostrar();

            // Calcular y mostrar el promedio de un array de enteros
            int[] numeros = { 10, 20, 30, 40, 50 };

            // Crear una instancia de PrimerParcial
            PrimerParcial primerParcial = new PrimerParcial();

            double promedio = primerParcial.PromedioArrayEnteros(numeros);
            Console.WriteLine($"El promedio de los números es: {promedio}");

            //Console.ReadLine();
        }
    }
}
