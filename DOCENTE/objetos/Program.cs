namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Estudiante Suares = new Estudiante();
            Estudiante Pedro = new Estudiante();
            Suares.SetNombre("Suares");
            Pedro.SetNombre("Pedro");
            Suares.RestarEdad(5);
            Suares.RestarEdad(10);

            Pedro.AplazarEstudiante();
            //MyEstudiante.AgregarPuntosExtra(2);

            string estadoEstudiante1 = Suares.AprobadoReprobado();
            string estadoEstudiante2 = Pedro.AprobadoReprobado();
            
            Console.WriteLine("NOMBRE: ");
            Console.WriteLine(Suares.nombre);
            Console.WriteLine("EDAD: ");
            Console.WriteLine(Suares.edad);
            Console.WriteLine("NOTA: ");
            Console.WriteLine(Suares.nota);
            Console.WriteLine("estadoEstudiante: Suares");
            Console.WriteLine(estadoEstudiante1);
            Console.WriteLine("estadoEstudiante: Pedro");
            Console.WriteLine(estadoEstudiante2);
            
        }
    }
}