using System;

class Program
{
    static void Main()
    {
       /* int[,] matriz = {
            { 5, 2, 1, 1, 1 },
            { 1, 1, 4, 5, 2 },
            { 2, 2, 3, 2, 3 },
            { 9, 8, 6, 7, 4 },
            { 5, 2, 9, 7, 8 }
        };*/

        SumarElementos sumador = new SumarElementos(matriz);
        sumador.SumarElementosPorFila();
    
        TableroDamas tablero = new TableroDamas();
        Console.WriteLine("Tablero de Damas:");
        tablero.MostrarTablero();
        
        // Ejecución de MostrarDigImparesRecursivos
        NumerosImpares numerosImpares = new NumerosImpares();
        int numero = 123456789; // Cambia el número según lo que desees
        Console.WriteLine("Dígitos impares del número de forma recursiva:");
        numerosImpares.MostrarDigImparesRecursivos(numero);

    }
}
