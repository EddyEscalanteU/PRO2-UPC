namespace SegundoParcial{
    class Program
    {

        //1.Convertir el siguiente algoritmo interativo a su equivalente de manera recursiva
        public static void Main(string[] args)
        {
            //1.
            MostrarDigImparesIterativo(7829367);
            MatrizSerie();
            
        }
        public static void MostrarDigImparesIterativo(int N)
        {
            int NroAux = N;
            if(NroAux == 0){
                return;
            }else{
                int dig = NroAux % 10;
                if (dig  % 2 != 0){
                    Console.WriteLine("Dig: " + dig);
                }
                MostrarDigImparesIterativo(NroAux / 10);
               
            }
        }

        //segundo examen

        public static void MatrizSerie()
    {
        int filas = 5;
        int columnas = 5;


        int[,] matriz = new int[filas, columnas];

        int contador = 1;
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = contador;
                contador++;
            }
        }

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
        }
    }
        
}