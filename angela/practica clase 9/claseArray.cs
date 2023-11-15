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
        for (int i = 0; i < ArrayCadenas.length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        
        }
        Console.WriteLine( resp + "]"); 
    }
            char c0 = char.parse(A.ArrayCadena[0]);
            char c1 = char.parse(A.ArrayCadena[1]);
            char c2 = char.parse(A.ArrayCadena[2]);
            char c3 = char.parse(A.ArrayCadena[3]);

            Console.WriteLine(c0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine((int)c0);
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c2);
            Console.WriteLine((int)c3);

            char c = ´A´ ; //crear un caracter
            Console.WriteLine((int)c);//char to int
            Console.WriteLine((char)c);//int to char
            string srtr = "A";// crear un string con solo una letra
            Console.WriteLine

            public void GenerarAbcdario(){
                for (int i =97; i <= 122; i++)
                {
                    int numero = i;
                    char letra = (char)numero;
                    Console.WriteLine(numero + ": " + letra);
                }
            }
            public void IntercarlarPrimeroUltimo()
            {
                int n  = ArrayCadenas.length -1;
                string aux = ArrayCadenas [0];
                ArrayCadenas[0] =ArrayCadenas[n];
                ArrayCadenas[n] = aux;
            }

            //  https://www.mecanografia-online.com/









}