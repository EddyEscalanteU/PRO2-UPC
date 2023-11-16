namespace Clase8
{
    public class Program{
        public static void Main(string[] args)
        {
            /*ClaseArray A = new ClaseArray(5);
            A.ArrayEnteros[0] = 1;
            A.ArrayEnteros[1] = 9;
            A.ArrayEnteros[2] = 10;
            A.ArrayEnteros[3] = 2;
            A.ArrayEnteros[4] = 7;
            A.MostrarArray();
            
            ClaseArray B = new ClaseArray(3);
            B.ArrayEnteros[0] = 50;
            B.ArrayEnteros[1] = 90;
            B.ArrayEnteros[2] = 100;
           
            
            A.UnirArray(B);
            
            A.MostrarArray();*/

             
        Estudiante miEstudiante = new Estudiante(1, "Bryan Carrasco", 14274252, "Masculino", 19);
 
        
        miEstudiante.Mostrar();

         // Crear un objeto de la clase Materia
        Materia miMateria = new Materia(1, "Programación 2", "PRO2-UPC", 30);

        // Mostrar la información de la materia
        miMateria.Mostrar();

        // Crear un objeto de la clase Inscrito con las ID de estudiante y materia
        Inscrito inscripcion = new Inscrito(1, "01/08/2022", miEstudiante.Id, miMateria.Id);

        // Mostrar la información del inscrito
        inscripcion.Mostrar();
                  
        }

    }
}