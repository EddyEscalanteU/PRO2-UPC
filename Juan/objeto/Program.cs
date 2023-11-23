class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Crear instancias de la clase Estudiante
        Estudiante Suares = new Estudiante();
        Estudiante Pedro = new Estudiante();

        // Configurar nombres de los estudiantes
        Suares.SetNombre("Suares");
        Pedro.SetNombre("Pedro");

        // Modificar edades de los estudiantes
        Suares.RestarEdad(5);
        Suares.RestarEdad(10);

        // Aplazar al estudiante Pedro
        Pedro.AplazarEstudiante();

        // Agregar puntos extra al estudiante Suares (comentado en tu código)
        // MyEstudiante.AgregarPuntosExtra(2);

        // Determinar el estado (aprobado/reprobado) de cada estudiante
        string estadoEstudiante1 = Suares.AprobadoReprobado();
        string estadoEstudiante2 = Pedro.AprobadoReprobado();

        // Mostrar información de Suares
        Console.WriteLine("NOMBRE: ");
        Console.WriteLine(Suares.nombre);
        Console.WriteLine("EDAD: ");
        Console.WriteLine(Suares.edad);
        Console.WriteLine("NOTA: ");
        Console.WriteLine(Suares.nota);
        Console.WriteLine("Estado del Estudiante Suares:");
        Console.WriteLine(estadoEstudiante1);

        // Mostrar información de Pedro
        Console.WriteLine("NOMBRE: ");
        Console.WriteLine(Pedro.nombre);
        Console.WriteLine("EDAD: ");
        Console.WriteLine(Pedro.edad);
        Console.WriteLine("NOTA: ");
        Console.WriteLine(Pedro.nota);
        Console.WriteLine("Estado del Estudiante Pedro:");
        Console.WriteLine(estadoEstudiante2);
    }
}
