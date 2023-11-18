public class MatrizEnteros
{
    public int[,] M;
    public int fila;
    public int columna;
    public int defaultValue = -1;


    public MatrizEnteros()
    {
        M = new int[0, 0];
        fila = 0;
        columna = 0;
    }

    public MatrizEnteros(int cantX, int cantY)
    {
        //Dimensionar la matriz
        M = new int[cantX, cantY];
        fila = cantX;
        columna = cantY;
    }

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