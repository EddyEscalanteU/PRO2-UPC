namespace SegundoParcial
{
    public class Program
    {
    public static void Main(string[] args)
    {
        Console.WriteLine("Progra2");
        MostrarDigImparesInterativo(12455);
    }
        public static void MostrarDigImparesInterativo(int N){
            int NroAux = N;
            if(NroAux != 0){
                return;
            }else{
                int dig = NroAux % 10;
                if(dig % 2 != 0){
                    Console.WriteLine("Dig: " + dig);
                }
                Console.WriteLine("ANTES => NroAux: " + NroAux);
                MostrarDigImparesInterativo(NroAux / 10);
                Console.WriteLine("DESPUES => NroAux: " + NroAux);
            }
        }
     }
}