public class MatrizEnteros
{
    //Elementos de la Matriz
    public int[,] M;

    //Cantidad de filas
    public int fila;

    //Cantidad de columnas
    public int columna;

    //Valor por defecto
    public int defaultvalue = -1;

    //El constructor vacio
    public MatrizEnteros(){
        M = new int[0,0];
        fila = 0;
        columna = 0;
    }

    //El constructor dandole la cantidad X y Y
    public MatrizEnteros(int cantX, int cantY)
    {
        //Dimensionar la matriz 
        M = new int[cantY, cantX];
        columna = cantX;
        fila = cantY;
    }

    //Cargar la matriz con valores por defecto
    public void CargarMatrizDefault()
    {
        //Dar valores por defecto a la matriz
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[y, x] = defaultvalue;
            }
        }


    }

    //Mostrar el contenido de la matriz
    public void MostrarMatriz()
    {
        string res = "";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {  
                int dato = M[y, x];
                res = res + dato + " , ";
            }
            res = res + "\n";
        }
        Console.WriteLine(res);

    }

    public void Insertar(int posX, int posY, int ele)
    {
        M[posX, posY] = ele;
    }

    public void LlenarMatriz_V1()
    {
        int dato = 1;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
            }
            dato = dato + 1;
        }

    }

    public void LlenarMatriz_V2()
    {
        int dato = 1;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
                dato = dato + 1;
            }
        }

    }

    public void LlenarMatriz_V3()
    {
        int dato = 16;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
                dato = dato - 1;
            }
        }

    }

    public void LlenarMatriz_V4()
    {
        int dato = 4;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
                dato = dato - 1;
            }
            dato = 4;
        }
        

    }

    public void LlenarMatriz_V5()
    {
        int dato = 4;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
            }
            dato = dato - 1;

        }
        

    }

}