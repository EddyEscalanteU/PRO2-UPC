public class ClaseArray{
    //propiedades

    public int[] ArrayEnteros;

    //constructor

    public ClaseArray(){
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad){
        ArrayEnteros = new int[cantidad];
    }

    //metodo (Procedimientos/Funciones)
    public void MostrarArray(){
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            Console.WriteLine("Posicion: " + i);
            Console.WriteLine(ArrayEnteros[i]);
        }
    }
    public void OrdenamientoBurbuja(){
        for (int i = 1; 1 < ArrayEnteros.Length; i++)
        {
            for (int j = 0; < (n / 2) + 1; i++)
                if (ArrayEnteros[j] > ArrayEnteros[j + 1])
                {
                    int aux = ArrayEnteros[j + 1];
                    ArrayEnteros[j] = ArrayEnteros[j + 1];
                    ArrayEnteros[j + 1] = aux;
                }
            } 
        }
    }
    public void IntercalarPrimeroUltimo();
    {
        int n = ArrayEnteros.Length;

        int aux = ArrayEnteros[0];
        ArrayEnteros[0] = ArrayEnteros[n - 1]
        ArrayEnteros[n - 1] = aux;
    }
}