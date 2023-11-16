namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            Console.WriteLine(estudiante1.nombreCompleto);
            estudiante1.Asignarnombre("MIguel");
            estudiante1.AsginarEdad(21);
            estudiante1.Asiganagenero("Masculino");
            estudiante1.AsginarID(123);
            estudiante1.AsginarCarnet(1267);

            Console.WriteLine("NOMBRE:");
            Console.WriteLine(estudiante1.nombreCompleto);
            Console.WriteLine("EDAD:");
            Console.WriteLine(estudiante1.edad);
            Console.WriteLine("GENERO:");
            Console.WriteLine(estudiante1.genero);
            Console.WriteLine("ID:");
            Console.WriteLine(estudiante1.ID);
            Console.WriteLine("CARNET");
            Console.WriteLine(estudiante1.carnet);;
        }
    }
}
