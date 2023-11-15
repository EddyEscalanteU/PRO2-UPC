namespace CalculoFubonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 1;

            //Mostramos el primer número el 0.
            Console.WriteLine(valor1);

            //En este caso generamos 30 sucesiones del código Fibonacci.
            for (int i = 0; i < 30; i++)
            {
                //Almacenamos el valor v1 en una variable temporal para no perderlo.
                int temp = valor1;

                //El valor 1 se convierte en el valor 2.
                valor1 = valor2;

                //Sumamos los valores.
                valor2 = temp + valor1;

                //Mostramos por pantalla el resultado. 
                Console.WriteLine(valor1);
            }
        }
    }
}