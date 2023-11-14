namespace clase8
{
    public class Program{ 
        public static void Main(string[] args)
        {
            claseArray A = new claseArray(4);
            A.ArrayEnteros[0] = 85;
            A.ArrayEnteros[1] = 74;
            A.ArrayEnteros[2] = 544;
            A.ArrayEnteros[3] = 12;

            A.mostrarArray();
            
        }
    }
}
