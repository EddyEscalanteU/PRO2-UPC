public class Recursividad
{
    // Propiedades
    // NADA

    // Constructor
    // NADA

    // Metodos
    public int  Factorial(int n)
    {
        if (n < 0)
        {
            return 0;//ERROR
        }
        else
        {
            if(n == 0 || n== 1)
            {
                return 1;
            }
        else
        {
            return n * Factorial( n - 1);
        }
        }
    }
    
}