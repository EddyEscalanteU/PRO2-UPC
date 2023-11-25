using System;

class Program2
{
    
    
    static void Main()
    {
       
        string[,] tablero = CrearTablero();
        MostrarTablero(tablero);
        
    }

    static string[,] CrearTablero()
    {
        
        string[,] tablero = new string[8, 8];

        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                
                if ((fila + columna) % 2 == 0)
                {
                    tablero[fila, columna] = "▒▒▒▒▒▒▒  "; 
                }
                else
                {
                    
                    if (fila < 3)
                        tablero[fila, columna] = "Blanco"; 
                    else if (fila > 4)
                        tablero[fila, columna] = "Rojo"; 
                    else
                        tablero[fila, columna] = "▒▒▒▒▒▒▒  "; 
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
