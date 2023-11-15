namespace Mynamespace;

public class Program
{
    static void Main(string[] args)
    {
        ClaseArray A = new ClaseArray(4);

        /*
            A.ArrayCadenas[0]="H";
            A.ArrayCadenas[1]="o";
            A.ArrayCadenas[2]="l";
            A.ArrayCadenas[3]="a";
            A.MostrarArray();
        */
            
            /*
            char c0 = char.Parse(A.ArrayCadenas[0]);
            char c1 = char.Parse(A.ArrayCadenas[1]);
            char c2 = char.Parse(A.ArrayCadenas[2]);
            char c3 = char.Parse(A.ArrayCadenas[3]);

            Console.WriteLine(c0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine((int)c0);
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c2);
            Console.WriteLine((int)c3);
            */

            /*
            char c = 'A'; // CREAR UN CARACTER
            Console.WriteLine((int)c);  // CHAR TO INT
            Console.WriteLine((char)65); // INT TO CHAR
            string str = "A"; //CREAR UN STRING CON SOLO UNA LETRA
            char character = (char.Parse(str));  //STRING TO CHAR

            //Console.WriteLine(character); para motrar el char 
            */

            //A.GenerarAbecedario();
            A.GeneraAbecedarioMayuscula();
    }
}