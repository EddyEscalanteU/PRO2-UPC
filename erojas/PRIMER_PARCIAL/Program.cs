namespace Primer_Parcial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10] { 3, 10, 7, 4, 10, 3, 7, 10, 9, 10 };
            int elemento = 10;
            int frecuencia = FrecuenciaArrayEnteros.Frecuencia(elemento, array);
            Console.WriteLine("La frecuencia del elemento {0} es {1}", elemento, frecuencia);

            Materia myMateria =  new Materia();
            Console.WriteLine(myMateria.Mostrar());

            Estudiante myEstudiante =  new Estudiante();
            Console.WriteLine(myEstudiante.Mostrar());

            Inscrito myInscrito =  new Inscrito();
            Console.WriteLine(myInscrito.Mostrar());
        }
    }
}