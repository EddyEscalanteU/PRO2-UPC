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
        int triangulo = fila;
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
                if (y >= triangulo - 1)
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
                if (y >= triangulo - 1)
                {
                    M[x, y] = dato;
                }
            }
            triangulo--;
        }
    }
    public void LlenarMatrizRectangulo_v1()
    {
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (y <= (fila / 2))
                {
                    M[x, y] = dato;
                }
            }
        }
    }
    public void LlenarMatrizRectangulo_v2()
    {
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (y >= (fila / 2))
                {
                    M[x, y] = dato;
                }
            }
        }
    }
    public void LlenarMatrizRectangulo_v3()
    {
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            if (x <= (columna / 2))
            {
                for (int y = 0; y < fila; y++)
                {
                    M[x, y] = dato;
                }
            }
        }
    }
    public void LlenarMatrizRectangulo_v4()
    {
        int dato = 7;
        for (int x = 0; x < columna; x++)
        {
            if (x >= (columna / 2))
            {
                for (int y = 0; y < fila; y++)
                {
                    M[x, y] = dato;
                }
            }
        }
    }

    public void MatrizSerie_MasUno()
    {
        int datoPrevioA = 0;
        int datoPrevioB = 1;
        int datoPrevioC = 0;
        int dato = 0;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                dato = datoPrevioA + datoPrevioB + datoPrevioC;
                M[x, y] = dato;

                datoPrevioA = datoPrevioB;
                datoPrevioB = datoPrevioC;
                datoPrevioC = dato;
            }
        }
    }
    public void MatrizSerie_Domino()
    {
        int datoA = 1;
        int datoB = 6;
        bool cambiar = true;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (cambiar)
                {
                    M[x, y] = datoA;
                    datoA++;
                    cambiar = false;
                }
                else
                {
                    M[x, y] = datoB;
                    datoB--;
                    cambiar = true;
                }

            }
        }
    }
    public void MatrizSerie_DominoRecursivo()
    {
        int datoA = 1;
        int datoB = 6;
        bool cambiar = true;
        AuxDominioRecursivo(0, 0, datoA, datoB, cambiar);
    }

    private void AuxDominioRecursivo(int x, int y, int datoA, int datoB, bool cambiar)
    {
        if (x < columna && y < fila)
        {
            if (cambiar)
            {
                M[x, y] = datoA;
                AuxDominioRecursivo(x, y + 1, datoA + 1, datoB, !cambiar);
            }
            else
            {
                M[x, y] = datoB;
                AuxDominioRecursivo(x, y + 1, datoA, datoB - 1, !cambiar);
            }
        }
        else if (x + 1 < columna)
        {
            AuxDominioRecursivo(x + 1, 0, datoA, datoB, cambiar);
        }
    }
}