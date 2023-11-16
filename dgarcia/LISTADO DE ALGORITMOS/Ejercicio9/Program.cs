using System;
namespace MyNamespace
{

    public class EncontrarDiferenciaArray
    {
        public static void Main()
        {
            int[] arr1 = new int[] { 2, 4, 6, 8, 10 };
            int[] arr2 = new int[] { 2, 7, 10 };

            var diff = arr1.Except(arr2);
            Console.WriteLine("La diferencia es: " + String.Join(", ", diff));   
        }
    }
}
