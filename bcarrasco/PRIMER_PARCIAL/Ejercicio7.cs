public class ClaseArray
{
    
    public int[] ArrayEnteros;

   
    public ClaseArray()
    {
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
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

    public void UnirArray(ClaseArray B)
    {
        int n1 = ArrayEnteros.Length;
        int n2 = B.ArrayEnteros.Length;
        int newN = n1 + n2;
        ClaseArray C = new ClaseArray(newN);
        for (int i = 0; i <= n1 - 1; i++)
        {
            C.ArrayEnteros[i] = ArrayEnteros[i];
        }
        for (int j = 0; j <= n2 - 1; j++)
        {
            C.ArrayEnteros[n1 + j] = B.ArrayEnteros[j];
        }
        ArrayEnteros = C.ArrayEnteros;

    }

}






