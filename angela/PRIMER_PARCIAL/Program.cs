namespace Estudiantes{
    class Program{
        public static void Main(string[] arg)
        {
            Estudiante variableJuan = new Estudiante();
            Console.WriteLine(variableJuan.Mostrar());

            Inscrito variableInscrito= new Inscrito();
            Console.WriteLine(variableInscrito.Mostrar());

             Materia variableMateria= new Materia();
            Console.WriteLine(variableMateria.Mostrar());

        }

    }

}