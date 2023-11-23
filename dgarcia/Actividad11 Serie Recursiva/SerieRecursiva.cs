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