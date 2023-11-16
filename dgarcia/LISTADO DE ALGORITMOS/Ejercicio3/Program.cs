
namespace Myclass
{
    public class RetornarPromedioArray
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };

            double sumatoria = 0;

            foreach (double calificacion in arr)
            {

                sumatoria += calificacion;
            }

            double promedio = sumatoria / arr.Length;
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
