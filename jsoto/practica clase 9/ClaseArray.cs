using System.Globalization;

public class ClaseArray
{
    public string[] ArrayCadenas;

    //contructores
    public ClaseArray()
    {
        ArrayCadenas = new string [0];
    }
     public ClaseArray(int cant)
    {
        ArrayCadenas = new string[cant];
    }

public void MostararArray()
    {
        string resp = "[";
        for(int i = 0; i < ArrayCadenas.Length; i++){
            resp += ArrayCadenas [i] + ",";

        }
        Console.WriteLine(resp + "]");

    } 
    public void GenerarAbecedario()
    {
        for(int i = 97; i <= 122; i++)
        {
            int numero = i;
            char letra = (char) numero;
            Console.WriteLine(numero + ": " + letra);
        }
    }

    public void intercambiarPrimeroUlitmo()
    {
        int n = ArrayCadenas.Length - 1;
        string aux = ArrayCadenas[0];
        ArrayCadenas[0] = ArrayCadenas[n];
        ArrayCadenas[n] = aux;

    }
}
