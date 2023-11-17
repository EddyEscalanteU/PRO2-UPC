namespace MyClase;

public class Program
{
    static void Main(string[] args)
    {
        //1.-Encontrar el máximo o el mínimo y mostrarlo en la consola de un array de enteros
        Console.WriteLine("Ejercicio1 ");

        ClaseArrayEntero A = new ClaseArrayEntero(5);
        A.ArrayEnteros[0] = 1;
        A.ArrayEnteros[1] = 9;
        A.ArrayEnteros[2] = 10;
        A.ArrayEnteros[3] = 2;
        A.ArrayEnteros[4] = 7;
        A.MostrarArray();
        Console.WriteLine("El numero menor es: " + A.ArrayEnteros.Min());
        Console.WriteLine("El numero mayor es: " + A.ArrayEnteros.Max());

        //2.- Retornar la suma de un array de enteros
        Console.WriteLine("------------------------- ");
        Console.WriteLine("Ejercicio2 ");

        A.SumaArrayEnteros();

        //3.- Retornar el promedio de un array de enteros
        Console.WriteLine("------------------------- ");
        Console.WriteLine("Ejercicio3 ");
        A.PromedioArrayEnteros();

        //4.- Buscar un elemento en un array de cadenas, en caso de encontrar el elemento en el array de cadenas, 
        //mostrar "TRUE" y en caso de no encontrar el elemento en el array de cadenas, mostrar "FALSE"
        Console.WriteLine("------------------------- ");
        Console.WriteLine("Ejercicio4 ");

        ClaseArray C = new ClaseArray(4);           
            
        C.BuscarElementoArrayCadenas(C.ArrayCadenas);

        Console.WriteLine("------------------------- ");
        Console.WriteLine("Ejercicio8 ");

        ClaseArray B = new ClaseArray(4);           
            B.ArrayCadenas[0] = "A";
            B.ArrayCadenas[1] = "c";
            B.ArrayCadenas[2] = "e";
            B.ArrayCadenas[3] = "M";
        B.MostrarArray();
            Console.WriteLine("-----------------");

            char c0 = char.Parse(B.ArrayCadenas[0]);
            char c1 = char.Parse(B.ArrayCadenas[1]);
            char c2 = char.Parse(B.ArrayCadenas[2]);
            char c3 = char.Parse(B.ArrayCadenas[3]);

            Console.WriteLine(c0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine((int)c0);
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c2);
            Console.WriteLine((int)c3);
    }
}