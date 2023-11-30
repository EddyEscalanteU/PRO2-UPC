public class ClaseArrayCadenas
{
    public string[] ArrayCadenas;

    public ClaseArrayCadenas()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArrayCadenas(int cant)
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

    public void GenerarAbcdario()
    {
        for (int i = 97; i <= 122; i++)
        {
            int numero = i;
            char letra = (char)numero;
            Console.WriteLine(numero + ": " + letra);
        }
    }

    public void GenerarAbcdarioMAYUS2()
    {
        int cantAbcdario = (90 - 65) + 1;
        ArrayCadenas = new string[cantAbcdario];

        for (int i = 65; i <= 90; i++)
        {
            int numero = i;
            char letra = (char)numero;
            //Console.WriteLine(numero + ": " + letra);
            ArrayCadenas[i - 65] = letra + "";
        }
        MostrarArray();
    }

    public void GenerarAbcdarioMAYUS()
    {
        int cantAbcdario = (90 - 65) + 1;
        ClaseArrayCadenas B = new ClaseArrayCadenas(cantAbcdario);

        for (int i = 65; i <= 90; i++)
        {
            int numero = i;
            char letra = (char)numero;
            //Console.WriteLine(numero + ": " + letra);
            B.ArrayCadenas[i - 65] = letra + "";
        }
        B.MostrarArray();
    }

    public void IntercalarPrimeroUltimo()
    {
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

    public string[] GenerarSerieExamen(int cantidadElementos){
        int numA = 1 ;
        int numB = 2 ;
        bool sw = true;
        for(int i =0; i< cantidadElementos; i++){
            if(sw){
                ArrayCadenas[i] = numA + "";
                numA = numA + 5;
                sw = false;
            }else{
                ArrayCadenas[i] = numB + "";
                numB = numB + 2;
                sw = true;
            }
        }
        return ArrayCadenas;
    }
    
    
        public long Factorial(long n){
            if(n < 0){
                return 0;//ERROR negativo
            }else{
                if(n == 0 || n == 1){
                    //Console.WriteLine(n + " Llamada a la recursion ");
                    ArrayCadenas[n - 1] = 1 + "";
                    //Console.WriteLine("FIN de la recursion");
                    return 1;
                }else{
                    long fact =  n * Factorial(n-1);
                    ArrayCadenas[n - 1] = fact + " OK";
                    //Console.WriteLine(n + " Llamada a la recursion " + fact);
                    return fact;
                    //Console.WriteLine("Despues de la recursion");
                }
        }
    }
}