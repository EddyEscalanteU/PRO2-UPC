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
            Console.WriteLine("Posicion: " + i);
            Console.WriteLine(ArrayEnteros[i]);
        }
    }

    public void OrdenamientoBurbuja(){
        for (int i = 1; i <= ArrayEnteros.Length; i++)
        {
            for (int j = 0; j <= ArrayEnteros.Length - 2; j++)
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
}