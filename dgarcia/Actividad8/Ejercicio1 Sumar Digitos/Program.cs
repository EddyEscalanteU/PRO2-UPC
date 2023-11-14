using System;

namespace SumarDigitosDeUnNumero
{
    class SumarDigitosDeUnNumero
    {
        static void Main(string[] args)
        {
            int n = 123;
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("La suma de los digitos de: es: " + sum);
        }
    }
}