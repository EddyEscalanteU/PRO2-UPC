using System.Data;

public class MatrizEnteros
{

    //Elemeto de la matriz
    public int [,] M;

    //cantidad de filas
    public int fila;

    //cantidad de columnas
    public int columna;

    //valor por defecto 
    public int defaultValue = 5;

    // el constructor vacio
    public MatrizEnteros()
    {
        M = new int[0,0] ;
        fila = 0 ;
        columna = 0 ;
    }

    // El cosntructor dandole la cantidad en X y Y
    public MatrizEnteros (int cantX , int cantY)
    {
    // Dimensionar la matriz en este caso seria cantX y cantY

        M= new int [cantX,cantY];
        fila = cantX;
        columna =  cantY;
    }

    //Carga la matriz  con valores por defecto
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

    // Mostrar el contenido de la matriz

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
