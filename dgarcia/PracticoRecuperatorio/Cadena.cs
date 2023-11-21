public class ClaseArray
{
    public string[] ArrayCadenas;

    public ClaseArray()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArray(int cant)
    {
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }
    public void BuscarElementoArrayCadenas(string[] args)
        {
            ArrayCadenas[0] = "Ereli";
            ArrayCadenas[1] = "Maria";
            ArrayCadenas[2] = "Ines";
            ArrayCadenas[3] = "Joel"; 
            string busqueda = "fea";
            int indice = Array.IndexOf(ArrayCadenas, busqueda);
            if (indice == -1)
            {
                Console.WriteLine("TRUE", busqueda);
            }
            else
            {
                Console.WriteLine("FALSE", busqueda, indice);
            }
        }
}



    
