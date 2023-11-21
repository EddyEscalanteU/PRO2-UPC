using System;

namespace MyNamespace
{
    public class ClaseArray
    {
        public int[] ArrayEnteros;

        public ClaseArray(int cant)
        {
            ArrayEnteros = new int[cant];
        }

        public void MostrarArray()
        {
            string resp = "[";
            for (int i = 0; i < ArrayEnteros.Length; i++)
            {
                resp += ArrayEnteros[i] + ", ";
            }
            Console.WriteLine(resp + "]");
        }

        public void ArrayEnterosToArrayCadenas()
        {
            string[] equivalentesASCII = new string[ArrayEnteros.Length];

            for (int i = 0; i < ArrayEnteros.Length; i++)
            {
                equivalentesASCII[i] = ObtenerEquivalentesASCII(ArrayEnteros[i]);
            }

            // Mostrar los resultados
            Console.WriteLine("Array de enteros:");
            MostrarArray();

            Console.WriteLine("\nEquivalentes ASCII:");
            foreach (string equivalente in equivalentesASCII)
            {
                Console.Write(equivalente + " ");
            }
        }

        private string ObtenerEquivalentesASCII(int numero)
        {
            char caracter = (char)numero;
            return caracter.ToString();
        }
    }
}
