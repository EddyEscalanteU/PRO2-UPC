public class PromedioArray 
{
    public int[] ArrayEnteros; 

    public PromedioArray(int cantidad)
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

     public void PromedioArrayEnteros()
    {
        double promedio = 0;
        double suma = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
            promedio = suma / ArrayEnteros.Length;
        }  
        Console.WriteLine(promedio);
    }
}