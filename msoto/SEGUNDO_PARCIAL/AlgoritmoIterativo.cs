using System;

class NumerosImpares
{
    public void MostrarDigImparesRecursivos(int N)
    {
        if (N != 0)
        {
            int dig = N % 10;
            if (dig % 2 != 0)
            {
                Console.WriteLine("Dig: " + dig);
            }
            MostrarDigImparesRecursivos(N / 10);
        }
    }
}
