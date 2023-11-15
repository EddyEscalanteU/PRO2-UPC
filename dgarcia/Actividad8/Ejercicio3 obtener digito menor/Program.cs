using System;

namespace NumeroMayor
{
 class Program
 {
  static void Main (string[] args)
  {
    int NumeroMenor = 0, NumeroIngresado;
    int TotalNumeros;

    Console.WriteLine("Ingrese la cantidad de numeros : ");

    TotalNumeros = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= TotalNumeros; i++)
    {
        Console.WriteLine("Ingrese el numero: " + i);
        NumeroIngresado = Convert.ToInt32(Console.ReadLine());

        if (i == 1)
        {
            NumeroMenor = NumeroIngresado;
        }
        else
        {
            if (NumeroIngresado < NumeroMenor)
            {
                NumeroMenor = NumeroIngresado;
            }
        }
    }
    Console.WriteLine("----------");
    Console.WriteLine("El numero menor es : " + NumeroMenor);
    Console.ReadKey();
  }
 }
}