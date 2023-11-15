public class ClaseArray{
    string[] ArrayEnteros;

    public ClaseArray(){
        ArrayEnteros = new string[0];
    }

    public ClaseArray(int caant){
        ArrayCadena = new string[cant];
    }
     public ClaseArray(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }

    //Metodos (Procedimientos/Funciones)
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadena.Length; i++)
        {
            resp += ArrayCadena[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

}