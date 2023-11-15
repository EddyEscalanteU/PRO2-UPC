public class ClaseArray{

    public string [] ArrayCadena;
    
    public ClaseArray()
    {
        ArrayCadena = new string[0];
    }

    public ClaseArray(int cant){
        ArrayCadena = new string[cant];
    }
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadena.Length; i++)
        {
            resp += ArrayCadena[i] + ", ";

        }
        Console.WriteLine(resp + "]");
    }

    public void GenerarAbecedario(){
        for (int i = 97; i <= 122; i++)
        {
            int numero = i;
            char letra = (char)numero;
            Console.WriteLine(numero + ":" + letra);
            
        }
    }

    public void IntercalarPrimeroUltimo()
    {
        int n = ArrayCadena.Length - 1;
        string aux = ArrayCadena[0];
        ArrayCadena[0] = ArrayCadena[n];
        ArrayCadena[n] = aux;
    }

   // public void GenerarAbecedarioMAYUS(){
     //   int cantAbcdario = (90-65) + int;

    
}