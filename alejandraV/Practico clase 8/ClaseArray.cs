public class ClaseArray{
    //Propiedades
    public int[] ArrayEnteros;

    //Constructor
    public ClaseArray(){
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad){
        ArrayEnteros = new int[cantidad];
    }

    //Metodos (Procedimientos/Funciones)
    public void MostrarArray(){
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            Console.WriteLine("Posición: " + i);
            Console.WriteLine(ArrayEnteros[i]);
        }
    }

    public void OrdenamientoBurbuja(){
        int n = ArrayEnteros.Length;

        for (int i = 1; i < ArrayEnteros.Length; i++)
        {
            for (int j = 0; j < ArrayEnteros.Length -2; j++)
            if (ArrayEnteros[j] > ArrayEnteros[j + 1])
            {
                int aux = ArrayEnteros[j];
                ArrayEnteros[j] = ArrayEnteros[j + 1];
                ArrayEnteros[j + 1] = aux;
            }
        }
    }



    public void IntercalarPrimerUltimo()
    {
        int n = ArrayEnteros.Length;
        int aux = ArrayEnteros[0];
        ArrayEnteros[0] = ArrayEnteros[0 - 1];
        ArrayEnteros[n - 1] = aux;
    }

    public void Intercalar_Uno()
    {
        int n = ArrayEnteros.Length;
        for(int i = 1; i < (n / 2) + 1; i++)
        {
            int aux =ArrayEnteros [i - 1];
            ArrayEnteros[i - 1] = ArrayEnteros[n - 1];
            ArrayEnteros[n - i] = aux;
            //MostrarArray();
        }
    }

    public void DeleteByPosition(int position)
    {
        int n = ArrayEnteros.Length;
        for (int i = position; i < n - 1; i++)
        {
            int aux = ArrayEnteros[i];
            
        }
    }



}

