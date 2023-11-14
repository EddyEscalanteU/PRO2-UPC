public class ClaseArray{
    //Propiedades
    int[] ArrayEnteros;
    //Constructor
    public ClaseArray(int cantidad){
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

}


 