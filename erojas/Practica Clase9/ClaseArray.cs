public class ClaseArray
{
    public string[] ArrayCadena;
    public ClaseArray()
    {
        ArrayCadena = new string[0];

    }
    public ClaseArray(int cant){
        ArrayCadena = new string [cant];
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
    public void GenerarAbcdario(){
        for (int i = 97; i <= 122; i++)  
        {
            int numero = i;
            char letra = (char)numero;
            Console.WriteLine(numero + ": " + letra);
        }     
    }
    public void GenerarAbcdarioMayus2(){
        int cantAbcdario = (90 - 65) + 1;
        ArrayCadena = new string[cantAbcdario];

        for (int i =65; i <=90 ; i++)
        {
            int numero = i;
            char letra = (char)numero;
            //Console.WriteLine(numero + ": " + letra);
            ArrayCadena[i - 65] = letra + ""; 
        }
        MostrarArray();
    }
    public void GenerarAbcdarioMayus(){
        int cantAbcdario = (90-65) + 1;
        ClaseArray B = new ClaseArray(cantAbcdario);

        for (int i = 65; i <= 90; i++)
        {
             int numero = i;
            char letra = (char)numero;
            //Console.WriteLine(numero + ": " + letra);
            B.ArrayCadena[i - 65] = letra + ""; 
        }
        B.MostrarArray();
    }

    // para interercambiar el primero con el ultimo

    public void IntercalarPrimeroUltimo()
    {
        int n = ArrayCadena.Length - 1;
        string aux = ArrayCadena[0];
        ArrayCadena[0] = ArrayCadena[n];
        ArrayCadena[n] = aux;
    }
    public void Interseccion(string[] A, string[] B)
    {
        int k = 0;
        for (int i = 0; i <= A.Length - 1; i++)
        {
            string dato = A[i];
            //Console.WriteLine("------------: " + dato);
            for (int j = 0; j <= B.Length - 1; j++)
            {
                string dato2 = B[j];
                if (dato == dato2)
                {
                    ArrayCadena[k] = dato2;
                    k = k + 1;
                    //Console.WriteLine(dato2);
                }
            }
        }
    }
}
    
    
        

    



