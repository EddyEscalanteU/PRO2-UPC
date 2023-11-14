public class CLaseArray{
    //propiedades
    int[] ArrayEnteros;

    //constructor

    public CLaseArray(){
        ArrayEnteros = new int[0];
    }

    public CLaseArray(int cantidad){
        ArrayEnteros = new int[cantidad];
    }

    //metodos (procedimientos/funciones)
    
    public void MostrarArray(){
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            Console.WriteLine("Posicion: " +i);
            Console.WriteLine(ArrayEnteros(i));
        }
    }

    public void OrdenamientoBurbuja(){
        for (int i = 1; i <= ArrayEnteros.Length; i++)
        {
             for (int j = 0; j <= ArrayEnteros.Length -2; j++)
             {
                if (ArrayEnteros[j] > ArrayEnteros[j + i])
                {
                    int aux = ArrayEnteros[j];
                    ArrayEnteros[j] = ArrayEnteros[j + i];
                    ArrayEnteros[j + i] = aux;
                }
             }
        }
    }
    public void IntercalarPrimeroUltimo(){
        int n = ArrayEnteros.Length;
        for( int i = 1; i < (n/2) + 1; i++)
        {
            int aux = ArrayEnteros[i-1];
            ArrayEnteros[i-1] = ArrayEnteros[n - i];
            ArrayEnteros[n-1] = aux;
        }
    }
    public void SumarElementos(){
        int suma = 0; 
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma ArrayEnteros();
        }
        Console.WriteLine(suma);
    }

    public void MultiplicarElementosArray(){
        int multi 
    }
}