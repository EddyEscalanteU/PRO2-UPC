// En Program.cs

using System;

namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(4);
            A.ArrayEnteros[0] = 65;
            A.ArrayEnteros[1] = 97;
            A.ArrayEnteros[2] = 49;
            A.ArrayEnteros[3] = 33;

            A.ArrayEnterosToArrayCadenas();
        }
    }
}
