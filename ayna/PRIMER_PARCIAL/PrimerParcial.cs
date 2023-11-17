using System;

namespace Universidad
{
    public class PrimerParcial
    {
        public int PromedioArrayEnteros(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("El array no puede estar vacío.");
            }

            int suma = 0;

            foreach (int numero in array)
            {
                suma += numero;
            }

            return suma / array.Length;
        }
    }
}
