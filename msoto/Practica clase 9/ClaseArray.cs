public class ClaseArray
{
    public string[] ArrayCadenas;

    public ClaseArray()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArray(int cant)
    {
        ArrayCadenas = new string [cant];
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

    public void GenerarAbcdario(){
        for (int i = 97; i <= 122; i++)
        {
            int numero = i;
            char letra = (char)numero;
            Console.WriteLine(numero + ": " + letra);
        }
    }
    public void IntercalarPrimeroUltimo(
        {
            int n = ArrayCadenas.Length - 1;
            string aux = ArrayCadenas[0];
            ArrayCadenas[0] = ArrayCadenas[n];
            ArrayCadenas[n] = aux;
        }

    public void Intersecciones(string[ A, string])
    )
}
