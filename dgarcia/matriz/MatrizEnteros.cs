public class MatrizEnteros
{
    //Elemento de la Matriz
    public int[,] M;

    //Cantidad de filas
    public int fila;

    //Cantidad de columnas
    public int columna;

    //Valor por defecto
    public int defaultValue = -1;

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
        fila = cantX;
        columna = cantY;
    }

    //Cargar la matriz con valores por defecto
    public void CargarMatrizDefault()
    {
        //Dar valores por defecto a la matriz
        for (int x = 0; x < fila; x++)
        {
            for (int y = 0; y < columna; y++)
            {
                M[x, y] = defaultValue;
            }
        }
    }

    //Mostrar el contenido de la matriz
    public void MostrarMatriz()
    {
        string res = "";
        for (int x = 0; x < fila; x++)
        {
            for (int y = 0; y < columna; y++)
            {
                int dato = M[x, y];
                res = res + dato + " , ";
            }
            res = res + "\n";
        }
        Console.WriteLine(res);
    }


}