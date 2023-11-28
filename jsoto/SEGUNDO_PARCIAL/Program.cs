namespace SEGUNDO_PARCIAL
{
    public class Program
    {
        public static void Main(string[] args)
        {
          MostrarDigImparesRecursivo (20);
          MostrarDigImparesRecursivo(35);
        
        }
          public static void MostrarDigImparesIterativo(int N)
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
                Console.WriteLine("ANTES => NroAux: " + NroAux);
                MostrarDigImparesRecursivo(NroAux / 10);
                Console.WriteLine("DESPUES => NroAux: " + NroAux);
            }
        }
    }
}