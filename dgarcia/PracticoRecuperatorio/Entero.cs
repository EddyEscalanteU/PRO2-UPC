using System.Diagnostics.Contracts;

public class ClaseArrayEntero
{
    //Propiedades
    public int[] ArrayEnteros;

    //Constructor
    public ClaseArrayEntero()
    {
        ArrayEnteros = new int[0];
    }

    public ClaseArrayEntero(int cantidad)
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
    public void SumaArrayEnteros()
    {
        int[] valores = { 1, 2, 3, 4, 5 };
        int suma = 0;
        for (int i = 0; i < valores.Length; i++)
        {
            suma += valores[i];
        }
        Console.WriteLine("La suma es: " + suma);
    }

    public void PromedioArrayEnteros()
    {

        double[] SumaEnteros = { 10, 20, 10, 30, 40 };

        double sumatoria = 0;

        foreach (double calificacion in SumaEnteros)
        {

            sumatoria += calificacion;
        }

        double promedio = sumatoria / SumaEnteros.Length;
        Console.WriteLine("El Promedio es: " + promedio);
    }
}