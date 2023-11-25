public class MatrizCadenas
{
    public string [,] M;
    public int fila;
    public int columna;
    public string defaultValue = "▒▒▒▒▒▒";
    public MatrizCadenas (int cantX , int cantY)
    {
        M= new string [cantX,cantY];
        columna =  cantX;
        fila = cantY;
    }
    public void CargarMatrizDeafault()
    {
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[y,x]=defaultValue;
            }
        }
    }


    public void MostraMatriz()
    {
        string res ="";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                string dato = M[y,x];
                res = res + dato + ", " ;
            }

            res = res +"\n";
        }

        Console.WriteLine(res);
    }

    public string Obtener( int posX, int posY)
    {
        return M[posX,posY];
    }


    public void Insertar( int posX, int posY, string element)
    {
        int cant  = CantCarecteres (element);
        string espacios = "";
        if(cant <= 6)
        {
            int difCaracteres = 6 - cant ;
            for (int i = 0 ; i < difCaracteres; i++)
            {
                espacios = espacios +" ";
            }
        
        }
        M[posX,posY] = element + espacios;
    }   

    public int CantCarecteres( string dato)
    {
        return dato.Length;
    }
}