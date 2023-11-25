namespace SegundoParcial{
    class Program
    {

        //primer examen
        public static void Main(string[] args)
        {
            MostrarDigImparesIterativo(7829367);

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

        //
    }
}    