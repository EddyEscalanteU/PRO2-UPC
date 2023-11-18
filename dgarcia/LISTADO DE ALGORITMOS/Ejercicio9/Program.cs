using System;
namespace MyNamespace
{

    public class EncontrarDiferenciaArray
    {
        public static void Main()
        {
            int[] arrA = new int[] { 2, 4, 6, 8, 10 };
            int[] arrB = new int[] { 2, 7, 10 };

            var diff = arrA.Except(arrB);
            Console.WriteLine("La diferencia entre A y B es: " + String.Join(", ", diff));   
        }
    }
}
