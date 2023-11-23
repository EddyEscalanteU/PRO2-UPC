using System.Data;
// Aca se habia equivocado el docente y ase invertio ya que primero esta Y  despues X pero igual sirve o lo lee el c# ya que par este nose toma encuenta el orden si no la formula echa
public class MatrizEnteros
{

    //Elemeto de la matriz
    public int [,] M;

    //cantidad de filas
    public int fila;

    //cantidad de columnas
    public int columna;

    //valor por defecto 
    public int defaultValue = -1;

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
    // Dimensionar la matriz 

        M= new int [cantX,cantY];
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

    // Mostrar el contenido de la matriz

    public void MostraMatriz()
    {
        string res ="";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                // El programa c# maneja al reves el orden de X y Y
                int dato = M[y,x];
                res = res + dato + " , " ;
            }

            res = res +"\n";
        }

        Console.WriteLine(res);
    }

    // aca como esta invertido las x y las y cambiamos la estrcutura con esta formula
    public void Insertar(int posX,int posY,int element)
    {
        M[posX,posY] = element;
    }

    public void LlenarMatriz_v1()
    {
        int dato =1;
                for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
                
            }
            dato = dato + 1;
        }
    }

    public void LlenarMatriz_v2()
    {
        int dato =1;
                for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
                dato = dato + 1;
            }
        
        }
    }

}
