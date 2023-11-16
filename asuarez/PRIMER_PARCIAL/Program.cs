namespace Clase8
{
    public class Program{
        public static void Main(string[] args)
        {
        // Definir dos arrays
        //int[] arrayA = { 1, 2, 3 };
        //int[] arrayB = { 2, 3, 4, 5 };

        // Llamar al método de la clase para complementar y mostrar los arrays
        //Arrays.ComplementarYMostrarArrays(arrayA, arrayB);


        Estudiante miEstudiante = new Estudiante(1, "Angel Suarez", 13891210, "Masculino", 18);
 
        
        miEstudiante.Mostrar();

         // Crear un objeto de la clase Materia
        Materia miMateria = new Materia(1, "Programación 2", "PRO2-UPC", 30);

        // Mostrar la información de la materia
        miMateria.Mostrar();

        // Crear un objeto de la clase Inscrito con las ID de estudiante y materia
        Inscrito inscripcion = new Inscrito(1, "01/01/2023", miEstudiante.Id, miMateria.Id);

        Mostrar la información del inscrito
        inscripcion.Mostrar();
                  
        }

    }
}