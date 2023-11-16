public class ClaseArray{

    public string[] ArrayCadenas;
    public ClaseArray(){
        ArrayCadenas = new string[0];
    }

    public ClaseArray(int cant){
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

    public void GenerarAbcedario(){
        for (int i = 97; i <= 122; i++)
        {
            int numero = i;
            char letra = (char)numero;
            Console.WriteLine(numero + ": " + letra);
        }
    }

    public void GenerarAbcedarioMAYUS(){
        ArrayCadenas = new string[(90-65) + 1];
        for (int i = 65; i <= 90; i++)
        {
            int numero = i;
            char letra = (char)numero;
            //Console.WriteLine(numero + ": " + letra);
            ArrayCadenas[i - 65] = letra + "";

        }
        MostrarArray();

        
    }
    public void GenerarAbcedarioMAYUS2(){
        int cantAbcdario = (90-65) + 1;
        ClaseArray B = new ClaseArray(cantAbcdario);
        for (int i = 65; i <= 90; i++)
        {
            int numero = i;
            char letra = (char)numero;
            //Console.WriteLine(numero + ": " + letra);
            B.ArrayCadenas[i - 65] = letra + "";

        }
        B.MostrarArray();
    }

    public void IntercalarPrimeroUltimo(){
        int n = ArrayCadenas.Length - 1;
        string aux = ArrayCadenas[0];
        ArrayCadenas[0] = ArrayCadenas[n];
        ArrayCadenas[n] = aux;
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
                    ArrayCadenas[k] = dato2;
                    k = k + 1;
                    //Console.WriteLine(dato2);
                }
            }
        }

    }
    
}