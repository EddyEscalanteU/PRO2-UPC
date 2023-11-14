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
        for (int i = 1; i < ArrayEnteros.Length; i++)
        {
            
        }
    }
}