namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
            {
            Console.WriteLine("Area Cuadrado");
            int resp = calcularAreaCuadrdo(10);
            Console.WriteLine(resp);
            }
        static int calcularAreaCuadrdo(int L){
            int resultado = L*L;
            return resultado;
            
        }
    }   
}