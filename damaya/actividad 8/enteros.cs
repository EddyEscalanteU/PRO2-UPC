public class ArrayEnt
{
    //Propiedades
    public int[] ArrayEnteros;

    public int N;

    //Constructor
    public ArrayEnt()
    {
        ArrayEnteros = new int[0];
    }

    public ArrayEnt(int cantidad)
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

    public int SumaArrayEnteros()
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

    public int CalcularFibonacci(int n )
    {
        if((n == 1) || (n == 2))
        {
            return 1;
        }
        else
        {
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2); 
        }
    }

    public void UnirArray( ArrayEnt B )
    {
        int n1 = ArrayEnteros.Length;
        int n2 = B.ArrayEnteros.Length;
        int newN = n1 + n2;
         ArrayEnt  C = new  ArrayEnt (newN);
        for (int i = 0; i <= n1 - 1; i++)
        {
            C.ArrayEnteros[i] = ArrayEnteros[i];
        }
        for (int j = 0; j <= n2 - 1; j++)
        {
            C.ArrayEnteros[n1 + j] = B.ArrayEnteros[j];
        }
        ArrayEnteros = C.ArrayEnteros;
        MostrarArray();
    }

    public void Intercalar()
    {
        int n = ArrayEnteros.Length;
        int mitad = n / 2;
        for (int i = 1; i < mitad + 1; i++)
        {
            int aux = ArrayEnteros[i];
            ArrayEnteros[i ] = ArrayEnteros[n - i - 1];
            ArrayEnteros[n - i - 1] = aux; 
        }
        MostrarArray();
    }
    
    public void OrdenarArrayAcendente()
    {
        int n = ArrayEnteros.Length;
         for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (ArrayEnteros[j] > ArrayEnteros[j + 1]) {
                    
                    int aux = ArrayEnteros[j];
                    ArrayEnteros[j] = ArrayEnteros[j + 1];
                    ArrayEnteros[j + 1] = aux;
                    
                }
            }
         }
         MostrarArray();
    }

    public void OrdenarArraydesendente()
    {
        int n = ArrayEnteros.Length;
         for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (ArrayEnteros[j] < ArrayEnteros[j + 1]) {
                    
                    int aux = ArrayEnteros[j];
                    ArrayEnteros[j] = ArrayEnteros[j + 1];
                    ArrayEnteros[j + 1] = aux;
                    
                }
            }
         }
         MostrarArray();
    }

}    