namespace Programacion2
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            int[,] miMatriz = {
           {5, 2, 1, 1, 1},
            {1, 1, 4, 5, 2},
            {2, 2, 3, 2, 3},
            {9, 8, 6, 7, 4},
            {5, 3, 9, 7, 8}
        };

        int[] sumaColumnas = MatrizUtils.SumarElementosColumnas(miMatriz);

        Console.WriteLine("Suma de elementos por Fila:");
        for (int j = 0; j < sumaColumnas.Length; j++)
        {
            Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
        }
        
        }

         /*public static void MostrarDigImparesIterativo(int N)
        {
            int NroAux = N;
            while (NroAux != 0)
            {
                int dig = NroAux % 10;
                if(dig % 2 != 0){
                    Console.WriteLine("Dig: " + dig);
                }
                NroAux = NroAux / 10;
            }
        }

         public static void MostrarDigImparesRecursivo(int N){
            int NroAux = N;
            if(NroAux == 0){
                return;
            }else{
                int dig = NroAux % 10;
                if(dig % 2 != 0){
                    Console.WriteLine("Dig: " + dig);
                }
                
                MostrarDigImparesRecursivo(NroAux / 10);
                
            }
        }*/

        
    }

}