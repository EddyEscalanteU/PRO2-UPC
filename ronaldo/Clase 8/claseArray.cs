public class claseArray
//Propiedades
{
    public int[]ArrayEnteros;

    //Contructor

    public claseArray(int cantidad)
    {
        ArrayEnteros = new  int [cantidad];
    }

    //metodos (procedimientos /funciones)

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + " , ";
        }
            Console.WriteLine(resp +"]");
    }

    public void OrdenamientoBurbuja()
    {
        for  (int i = 1; i <= ArrayEnteros.Length; i++)
        {
            for (int j = 0; j <= ArrayEnteros.Length - 2 ; j++)
            {
                if(ArrayEnteros[j] > ArrayEnteros[j+1])
                {
                    int aux = ArrayEnteros[j];
                    ArrayEnteros[j]= ArrayEnteros[j + 1] ;
                    ArrayEnteros[j + 1] = aux ;
                }
            }
        }
    }
    public void IntercalarPrimeroUltimo()
    {
        int n = ArrayEnteros.Length;
        
        int aux = ArrayEnteros[0];
        ArrayEnteros[0] = ArrayEnteros[n-1];
        ArrayEnteros[n-1] = aux ;
    }

    public void Intercalar_Uno()
    {
        int n = ArrayEnteros.Length;
        for (int i = 1; i < (n / 2)+ 1; i++)
        {
            int aux = ArrayEnteros[i - 1];
            ArrayEnteros[i - 1] = ArrayEnteros[n - i];
            ArrayEnteros[n - i] = aux ;
            //MonstarArray();
        }
    }

    public void DeletebyPosition(int position)
    {
        int n = ArrayEnteros.Length;
        int newN = n - 1;
        claseArray B = new claseArray(newN);
        for (int i = 0; i < position; i++)
        {
            B.ArrayEnteros[i] = ArrayEnteros[i];
        }
        // ignoro el elmento ELIMINAR

        for (int j = position + 1 ; j <= n - 1; j++)
        {
            B.ArrayEnteros[j - 1] = ArrayEnteros[j];
        }
        ArrayEnteros = B.ArrayEnteros;
    }

    public void Unirray(claseArray B)
    {
        int n1 = ArrayEnteros.Length;
        int n2 = B.ArrayEnteros.Length;
        int newN = n1 +n2;
        claseArray C = new claseArray(newN);
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

    public void SumarElmentoArray()
    {
        int suma = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        Console.WriteLine(suma);
    }

    public void MultiplicarElmentoArray()
    {
        int multi = 1 ;
        int n =ArrayEnteros.Length;
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
            if (ArrayEnteros[i] % 2 != 0)
        {
            ArrayEnteros[i] = (ArrayEnteros[i] * ArrayEnteros[i]);
        }
        }
    }
    
}