namespace ProgramacionDos
{
    class Program
    {
        public static void Main(string[] args)
        {

            Estudiante e1 = new Estudiante (123, 456, "Juan", "AppP", "AppM", 18);


            e1.Mostrar();




            
             
            /*Estudiante estudiante = new Estudiante();

            estudiante.SetCarnet("3916529");
            estudiante.SetCodigoEstudiante("UPC7140");
            estudiante.SetNombre("Nohemi Alejandra");
            estudiante.SetApellidoPaterno("Villagomez");
            estudiante.SetApellidoMaterno("Flores");
            estudiante.SetEdad(31);

            Console.WriteLine($"Carnet: {estudiante.GetCarnet()}");
            Console.WriteLine($"Código de Estudiante: {estudiante.GetCodigoEstudiante()}");
            Console.WriteLine($"Nombre: {estudiante.GetNombre()}");
            Console.WriteLine($"Apellido Paterno: {estudiante.GetApellidoPaterno()}");
            Console.WriteLine($"Apellido Materno: {estudiante.GetApellidoMaterno()}");
            Console.WriteLine($"Edad: {estudiante.GetEdad()}");
            */
        }
    }
}
