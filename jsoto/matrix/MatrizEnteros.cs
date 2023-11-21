public class MatrizEnteros
{
    public int[,] M; //Elemento de la Matriz
    public int fila;//Cantidad de filas
    public int columna;//Cantidad de columnas
    public int defaultValue = 99;//Valor por defecto

    //El constructor vacio
    public MatrizEnteros()
    {
        M = new int[0, 0];
        fila = 0;
        columna = 0;
    }

    //El constructor dandole la cantidad X y Y
    public MatrizEnteros(int cantX, int cantY)
    {
        //Dimensionar la matriz
        M = new int[cantX, cantY];
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
                M[y, x] = defaultValue;
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


    public void LlenarMatriz_v1()
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

    public void LlenarMatriz_v2()
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

    public void LlenarMatriz_v3()
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

    public void LlenarMatriz_v4()
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
    public void LlenarMatrizTriangulo_v1()
    {
        int triangulo = 1;
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (y < triangulo)
                {
                    M[x, y] = dato;
                }
            }
            triangulo++;
        }
    }

     public void LlenarMatrizTriangulo_v4()
    {
        int triangulo = 5;
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (y < triangulo)
                {
                    M[x, y] = dato;
                }
            }
            triangulo--;
        }
    }
        public void LlenarMatrizTriangulo_v3()
    {
        int triangulo = 1;
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (y >= triangulo -1)
                {
                    M[x, y] = dato;
                }
               
            }
             triangulo++;
        }

    }
     public void LlenarMatrizTriangulo_v2()
    {
        int triangulo = fila;
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (y >=  triangulo -1)
                {
                    M[x, y] = dato;
                }
            }
            triangulo--;
        }
    }
    
}