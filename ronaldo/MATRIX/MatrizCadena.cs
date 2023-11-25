public class MatrizCadenas
{
    public string [,] M;
    public int fila;
    public int columna;
    public string defaultValue = "▒▒▒▒▒▒▒";

     // El cosntructor dandole la cantidad en X y Y
    public MatrizCadenas (int cantX , int cantY)
    {
    // Dimensionar la matriz 

        M= new string [cantX,cantY];
        columna =  cantX;
        fila = cantY;
    }

    //Carga la matriz  con valores por defecto
    public void CargarMatrizDeafault()
    {
    // Dar valores por defecto ala matriz ya que aca estamos haciento una matriz de ceros (0) j seria X y k seria y

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
                // El programa c# maneja al reves el orden de X y Y
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


    public void Insertar( int posX, int posY, string element)// en elemnt ponemos string poque mi matriz es cadena
    {
        int cant  = CantCarecteres (element);
        string espacios = "";
        if(cant <= 7)
        {
            int difCaracteres = 7 - cant ;
            for (int i = 0 ; i < difCaracteres; i++)
            {
                espacios = espacios + " ";
            }
        
        }
        M[posX,posY] = element + espacios;
    }   

    public int CantCarecteres( string dato)
    {
        return dato.Length;
    }

        public void LlenarMatriz_v1()
    {
        int i = 1 ;
        string dato ="UPC ";
                for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
                
            }
            dato = dato + "_" + 1;
            i ++ ;
        }
    }
}