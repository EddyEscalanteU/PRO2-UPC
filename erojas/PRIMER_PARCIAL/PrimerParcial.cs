using System;

namespace Primer_Parcial
{
    public class FrecuenciaArrayEnteros
    {
        public int[] ArrayEnteros;

        
        

        public FrecuenciaArrayEnteros(int cantidad){
            ArrayEnteros = new int[cantidad];
        }

        
        public static int Frecuencia(int elemento, int[] array)
        {
            int frecuencia = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                {
                    frecuencia++;
                }
            }return frecuencia;
        }
    }
}