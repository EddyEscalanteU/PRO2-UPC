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
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            Console.WriteLine("Pocision : " + i);
            Console.WriteLine(ArrayEnteros[i]);
        }
    }
    
}