namespace claseEntero

{
    public class Program{
        public static void Main(string[] args)
        {
             ArrayEntero A = new ArrayEntero(4);
            A.Numeros [0] = 2;
            A.Numeros [1] = 8;
            A.Numeros [2] = 3;
            A.Numeros [3] = 6;
            A.MostrArarray();
            A.MostrarNumeroMayor();
          
            
        }
    }
}
