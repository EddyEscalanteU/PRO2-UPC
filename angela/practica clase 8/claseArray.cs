using System. diagnostics.contracts;

public class claseArray
{
     //propiedades
    public int[] ArrayEnteros;

    //constructor
    public claseArray()
    {
        ArrayEnteros = new int[0];
    }

    public claseArray(int cantidad);
    {
         ArrayEnteros = new int[cantidad];
    }

    //metodos (procedimiento/funciones)
    public void mostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        
        }
        console.WriteLine( resp + "]"); 
    }

    public void ordenmientoBurbuja()
    {
        int n = ArrayEnteros.length;

        for (int i = 1; j <= n - 2; j++)
        {
              if (ArrayEnteros[j] > ArrayEnteros[j + 1])
            
            {
                
                int aux =ArrayEnteros[j];
                ArrayEnteros[j] = ArrayEnteros [j + 1];
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


    public void SumarElementosArray()
    {
        int suma = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        Console.WriteLine(suma);
    }
    public void MultiplicarElementosArray()
    {
        int multi = 1;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            multi = multi * ArrayEnteros[i];
        }
        Console.WriteLine(multi);
    }

    public void ElevarCuadrado()
    {
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            ArrayEnteros[i] = (ArrayEnteros[i] * ArrayEnteros[i]);
        }
    }

}

