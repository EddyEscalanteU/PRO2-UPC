namespace Mynamespace;

public class Program
{
    static void Main(string[] args)
    {
        ArrayCadenasToArrayEnteros A = new ArrayCadenasToArrayEnteros(9);

        
            A.ArrayCadenas[0]="R";
            A.ArrayCadenas[1]="o";
            A.ArrayCadenas[2]="n";
            A.ArrayCadenas[3]="a";
            A.ArrayCadenas[4]="l";
            A.ArrayCadenas[5]="d";
            A.ArrayCadenas[6]="o";
            A.ArrayCadenas[7]="Z";
            A.ArrayCadenas[8]="G";
            A.MostrarArray();

            A.GeneradorNumerosACII();
            Console.WriteLine("-----------------------------");
            A.GeneradorAbecedarioMinisculaASCII();
            Console.WriteLine("-----------------------------");
            A.GeneradorAbecedarioMayusculasASCII();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            A.TodoslosEnterosdeASCII();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            A.GeneradordeEquivalenciASCII();

    }
}