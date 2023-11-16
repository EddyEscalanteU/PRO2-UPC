using System;
namespace Myclass
{
public static class BuscarElementoArray
{
    public static bool find<T>(this T[] array, T target) {
        return array.Contains(target);
    }
}
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int target = 7;
 
        bool isExist = array.find(target);
        if (isExist) {
            Console.WriteLine("TRUE");
        }
        else {
            Console.WriteLine("FALSE");
        }
    }
}
}