namespace Primer_Parcial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Estudiante estudiante1 = new Estudiante();
            Console.WriteLine(estudiante1.Mostrar());

            Console.WriteLine("--------------------------------------------------------------------");
            Materia materia1 = new Materia();
            Console.WriteLine(materia1.Mostrar());

            Console.WriteLine("--------------------------------------------------------------------");
            Inscrito inscrito1 = new Inscrito();
            Console.WriteLine(inscrito1.Mostrar());
          */

            PromedioArray A = new PromedioArray(5);
             A.ArrayEnteros[0] = 1;
            A.ArrayEnteros[1] = 9;
            A.ArrayEnteros[2] = 10;
            A.ArrayEnteros[3] = 2;
            A.ArrayEnteros[4] = 7;
            A.PromedioArrayEnteros();
            A.MostrarArray();




        }
    }
}