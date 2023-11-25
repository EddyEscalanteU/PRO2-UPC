namespace PrimerParcial
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
        Estudiante VariableDiego =  new Estudiante();
        Console.WriteLine(VariableDiego.Mostrar());
        
        Console.WriteLine("-------------------");
        
        //Inscrito NuevoIncrito = new Inscrito();
        //Console.WriteLine(NuevoIncrito.Mostrar());

        Console.WriteLine("-------------------");

        Materia MyMateriaPro2 = new Materia();
        Console.WriteLine(MyMateriaPro2.Mostrar());
    }
}
}