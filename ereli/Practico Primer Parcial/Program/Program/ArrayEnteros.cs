using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClaseArra
{
    //Propiedades
    public int[] ArrayEnteros;

    //Constructor
    public ClaseArra()
    {
        ArrayEnteros = new int[0];
    }

    public ClaseArra(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }

    //Metodos (Procedimientos/Funciones)
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }



    public int SumarElementosArray()
    {
        int suma = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        return suma;
    }

    public void MostraMaxMinArrayEnteros()
    {
        int max = ArrayEnteros[0];
        int min = ArrayEnteros[0];

        for (int i = 1; i < ArrayEnteros.Length; i++)
        {
            if (ArrayEnteros[i] > max)
            {
                max = ArrayEnteros[i];
            }

            if (ArrayEnteros[i] < min)
            {
                min = ArrayEnteros[i];
            }
        }

        Console.WriteLine("El máximo es: " + max);
        Console.WriteLine("El mínimo es: " + min);
    }

    public int PromedioArrayEnteros()
    {
        int suma = 0;
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            suma += ArrayEnteros[i];
        }
        return suma / ArrayEnteros.Length; 
    }

    public int FrecuenciaArrayEnteros(int nume)
    {
        int frecuencia = 0;
        for (int i = 0;i < ArrayEnteros.Length;i++)
        {
            if (ArrayEnteros[i] == nume)
            {
                frecuencia++;
            }
        }
        return frecuencia; 
    }

    
}