public class ClaseArray
{
    //Propiedades
    public int[] ArrayEnteros;

    //Constructor
    public ClaseArray()
    {
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad)
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

    public void OrdenamientoBurbuja()
    {
        int n = ArrayEnteros.Length;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j <= n - 2; j++)
            {
                if (ArrayEnteros[j] > ArrayEnteros[j + 1])
                {
                    int aux = ArrayEnteros[j];
                    ArrayEnteros[j] = ArrayEnteros[j + 1];
                    ArrayEnteros[j + 1] = aux;
                }
            }
        }
    }

    public void IntercalarPrimeroUltimo()
    {
        int n = ArrayEnteros.Length;

        int aux = ArrayEnteros[0];
        ArrayEnteros[0] = ArrayEnteros[n - 1];
        ArrayEnteros[n - 1] = aux;
    }

    public void Intercalar_Uno()
    {
        int n = ArrayEnteros.Length;
        for (int i = 1; i < (n / 2) + 1; i++)
        {
            int aux = ArrayEnteros[i - 1];
            ArrayEnteros[i - 1] = ArrayEnteros[n - i];
            ArrayEnteros[n - i] = aux;
            //MostrarArray();
        }
    }

    public void DeleteByPosition(int position)
    {
        int n = ArrayEnteros.Length;
        int newN = n - 1;
        ClaseArray B = new ClaseArray(newN);
        for (int i = 0; i < position; i++)
        {
            B.ArrayEnteros[i] = ArrayEnteros[i];
        }
        //ignoro el elemento a eliminar
        for (int j = position + 1; j <= n - 1; j++)
        {
            B.ArrayEnteros[j - 1] = ArrayEnteros[j];
        }
        ArrayEnteros = B.ArrayEnteros;
    }
}