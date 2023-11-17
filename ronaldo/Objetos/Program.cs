namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ronaldo Zegarrundo Gutierrez");
            Estudiante Myestudiante = new Estudiante();
            Myestudiante.SetNombre("UPC");
            Myestudiante.RestarEdad(5);
            Myestudiante.RestarEdad(10);

            Myestudiante.AplazarEsudiante(100);
            Myestudiante.AgregarPuntosExtras(2);

            string estadoEstudiante = Myestudiante.AprobadoReprobado();


            Console.WriteLine("NOMBRE:");
            Console.WriteLine(Myestudiante.nombre);
            Console.WriteLine("EDAD:");
            Console.WriteLine(Myestudiante.edad);
            Console.WriteLine("NOTA:");
            Console.WriteLine(Myestudiante.nota);
            Console.WriteLine("estadoEstudiante:");
            Console.WriteLine(estadoEstudiante);
        }
    }
}