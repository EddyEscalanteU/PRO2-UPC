using System;

class Program2
{
    static void Main()
    {
        // Crear y mostrar el tablero con fichas en palabras
        string[,] tablero = CrearTableroConFichas();
        MostrarTablero(tablero);
    }

    static string[,] CrearTableroConFichas()
    {
        string[,] tablero = new string[8, 8];

        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                // Alternar entre espacios en blanco y fichas en el tablero
                if ((fila + columna) % 2 == 0)
                {
                    tablero[fila, columna] = "  "; // Espacio en blanco
                }
                else
                {
                    // Poner nombres a las fichas (puedes personalizar esto)
                    if (fila < 3)
                        tablero[fila, columna] = "Blanco"; // Ficha blanca
                    else if (fila > 4)
                        tablero[fila, columna] = "Rojo"; // Ficha negra
                    else
                        tablero[fila, columna] = "  "; // Espacio en blanco en el medio
                }
            }
        }

        return tablero;
    }

    static void MostrarTablero(string[,] tablero)
    {
        
        Console.WriteLine("  --------------------------------");
        for (int fila = 0; fila < 8; fila++)
        {
            Console.Write((8 - fila) + "|");
            for (int columna = 0; columna < 8; columna++)
            {
                Console.Write(tablero[fila, columna].PadRight(4));
            }
            Console.WriteLine("|" + (8 - fila));
            Console.WriteLine("  --------------------------------");
        }
        
    }
}
