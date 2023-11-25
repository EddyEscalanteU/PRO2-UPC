class Program
{
    static void Main()
    {
        MatrizCadenas tablero = new MatrizCadenas(8, 8);

        // Inicializar el tablero con piezas negras (B) y blancas (W)
        InicializarTablero(tablero);

        // Mostrar el tablero en consola
        MostrarTablero(tablero);
    }

    static void InicializarTablero(MatrizCadenas tablero)
    {
        for (int fila = 0; fila < tablero.Filas; fila++)
        {
            for (int columna = 0; columna < tablero.Columnas; columna++)
            {
                if ((fila + columna) % 2 == 0)
                {
                    // Casillas blancas
                    tablero[fila, columna] = "W";
                }
                else
                {
                    // Casillas negras
                    tablero[fila, columna] = "B";
                }
            }
        }
    }

    static void MostrarTablero(MatrizCadenas tablero)
    {
        for (int fila = 0; fila < tablero.Filas; fila++)
        {
            for (int columna = 0; columna < tablero.Columnas; columna++)
            {
                Console.Write(tablero[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}

class MatrizCadenas
{
    private string[,] matriz;

    public int Filas { get; private set; }
    public int Columnas { get; private set; }

    public MatrizCadenas(int filas, int columnas)
    {
        Filas = filas;
        Columnas = columnas;
        matriz = new string[filas, columnas];
    }

    public string this[int fila, int columna]
    {
        get { return matriz[fila, columna]; }
        set { matriz[fila, columna] = value; }
    }
}
