public class ClaseArrayEquivalencias
{
    public string[] ArrayCadenas;

    public ClaseArrayEquivalencias()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArrayEquivalencias(int cant)
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
}