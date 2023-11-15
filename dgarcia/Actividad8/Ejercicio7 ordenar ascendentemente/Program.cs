using System;

public class OrdenamientoAscendente{
  public static void Main() {
    int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };
    Console.WriteLine("Lista sin Ordenamiento ");
    foreach (int value in arr) {
      Console.Write(value + " ");
    }
    Console.WriteLine("\n");
    Array.Sort(arr);
    Console.WriteLine("Lista ordenada de forma Ascendente ");
    foreach (int value in arr) {
      Console.Write(value + " ");
    }
  }
}