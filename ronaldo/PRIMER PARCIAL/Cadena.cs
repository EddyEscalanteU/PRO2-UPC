public class ArrayCadenasToArrayEnteros
{
    public string [] ArrayCadenas;

    public ArrayCadenasToArrayEnteros()
    {
        ArrayCadenas = new string [0];
    }
    public ArrayCadenasToArrayEnteros(int cant)
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
    public void GeneradorNumerosACII()
    {
        for (int i = 48; i <= 57; i++)
        {
            int numero = i;
            char letra =(char)numero;
            Console.WriteLine(numero + ":" + letra);
        }
    }
    public void GeneradorAbecedarioMinisculaASCII()
    {
        for (int i = 97; i <= 122; i++)
        {
            int numero = i;
            char letra =(char)numero;
            Console.WriteLine(numero + ":" + letra);
        }
    }

    public void GeneradorAbecedarioMayusculasASCII()
    {
        for (int i = 65; i <= 90; i++)
        {
            int numero = i;
            char letra =(char)numero;
            Console.WriteLine(numero + ":" + letra);
        }
    }
    public void TodoslosEnterosdeASCII()
    {
        int cantCaracteres = (255-00) +1;
        ArrayCadenas = new string[cantCaracteres];
        for (int i = 00; i <= 255 ; i++)
        {
            int numero = i;
            char letra =(char)numero;
            //Console.WriteLine(numero + ":" + letra);
            ArrayCadenas[i - 00] = letra + " " ;
        }
        MostrarArray();
    }

    public void GeneradordeEquivalenciASCII()
    {
        for (int i = 00; i <= 255; i++)
        {
            int numero = i;
            char letra =(char)numero;
            Console.WriteLine(numero + ":" + letra);
        }
    }
}