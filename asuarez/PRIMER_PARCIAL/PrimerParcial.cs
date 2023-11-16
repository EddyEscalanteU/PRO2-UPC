 using System.Diagnostics.Contracts;

using System;

public class Arrays
{
   public static void ComplementarYMostrarArrays(int[] a, int[] b)
    {
        // Complementar arrayA con elementos de arrayB
        int[] arrayComplementado = ComplementarArrays(a, b);

        // Mostrar el array complementado
        MostrarArray("Array Complementado:", arrayComplementado);
    }

    private static int[] ComplementarArrays(int[] a, int[] b)
    {
        // Crear un nuevo array con la longitud máxima entre a y b
        int[] arrayComplementado = new int[Math.Max(a.Length, b.Length)];

        // Copiar los elementos de a al nuevo array
        Array.Copy(a, arrayComplementado, a.Length);

        // Complementar arrayComplementado con elementos de b que no están en a
        foreach (int elementoB in b)
        {
            if (Array.IndexOf(a, elementoB) == -1)
            {
                Array.Resize(ref arrayComplementado, arrayComplementado.Length + 1);
                arrayComplementado[arrayComplementado.Length - 1] = elementoB;
            }
        }

        return arrayComplementado;
    }

    private static void MostrarArray(string mensaje, int[] array)
    {
        Console.WriteLine(mensaje);
        foreach (int elemento in array)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
