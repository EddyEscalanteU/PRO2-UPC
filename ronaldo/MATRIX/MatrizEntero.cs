using System.Data;

public class MatrizEnteros
{
    public int [,] M;

    public int fila;

    public int columna;

    //ejemplo con un variable si nos piden

    public int defaultValue = 5;

    public MatrizEnteros()
    {
        M = new int[0,0] ;
        fila = 0 ;
        columna = 0 ;
    }

    public MatrizEnteros (int cantX , int cantY)
    {
        // Dimensionar la matriz en este caso seria cantX y cantY

        M= new int [cantX,cantY];
        fila = cantX;
        columna =  cantY;
    }
    public void CargarMatrizDeafault()
    {
    // Dar valores por defecto ala matriz ya que aca estamos haciento una matriz de ceros (0) j seria X y k seria y

        for (int x = 0; x < fila ; x++)
        {
            for (int y = 0; y < columna; y++)
            {
                M[x,y]=defaultValue;
            }
        }
    }

    // aca es para mostrar la matriz un poco mas estetico o mejor

    public void MostraMatriz()
    {
        string res ="";
        for (int x = 0; x < fila; x++)
        {
            for (int y = 0; y < columna; y++)
            {
                int dato = M[x,y];
                res = res + dato + " , " ;
            }

            res = res +"\n";
        }

        Console.WriteLine(res);
    }
}
