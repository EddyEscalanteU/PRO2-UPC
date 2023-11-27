using System;

class TableroDamas
{
    private string[,] tablero;

    public TableroDamas()
    {
        tablero = new string[8, 8];
        InicializarTablero();
    }

    private void InicializarTablero()
    {
        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                if ((fila + columna) % 2 == 0)
                {
                    if (fila < 3)
                        tablero[fila, columna] = "BLANCO"; 
                    else if (fila > 4)
                        tablero[fila, columna] = "ROJO"; 
                    else
                        tablero[fila, columna] = " "; // Casillas vacías
                }
                else
                {
                    tablero[fila, columna] = " "; // Casillas vacías
                }
            }
        }
    }

    public void MostrarTablero()
    {
        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                Console.Write(tablero[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}
