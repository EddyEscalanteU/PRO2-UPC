public class ClaseArray
{
    public string [] ArrayCadenas;

    public ClaseArray()
    {
        ArrayCadenas = new string [0];
    }
    public ClaseArray(int cant)
    {
        ArrayCadenas = new string [cant];
    }

    public void MostrarArray()
    {
        string resp ="[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + " , ";
        }
        Console.WriteLine(resp + "]") ; 
    }
    public void GenerarAbecedario()
    {
        for (int i = 97; i <= 122; i++)
        {
            int numero = i;
            char letra =(char)numero;
            Console.WriteLine(numero + ":" + letra);
        }
    }
    public void GeneraAbecedarioMayuscula()
    {
        int cantAbecedario = (90-65) +1;
        ArrayCadenas = new string[cantAbecedario];
        for (int i = 65; i <= 90 ; i++)
        {
            int numero = i;
            char letra =(char)numero;
            //Console.WriteLine(numero + ":" + letra);
            ArrayCadenas[i - 65] = letra + " " ;
        }
        MostrarArray();
    }

    public void GeneraAbecedarioMayuscula2()
    {   
        int cantAbecedario = (90-65) + 1;
        ClaseArray B = new ClaseArray(cantAbecedario);

        for (int i = 65; i <= 90 ; i++)
        {
            int numero = i;
            char letra =(char)numero;
            //Console.WriteLine(numero + ":" + letra);
            B.ArrayCadenas[i - 65] = letra + " " ;
        }
        B.MostrarArray();
    }
}