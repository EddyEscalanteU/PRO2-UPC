namespace Programacion2
{
    public class Matrices
    {
        public static void Main(string[] args)
        {
            MatrizEnteros Matriz = new MatrizEnteros(5, 5);
            Matriz.defaultValue = 1;
            Matriz.CargarMatrizDefault();
            Matriz.MostrarMatriz();
            Console.WriteLine("---------------------------");
            Matriz.LlenarMatriz_v4();
            Matriz.M[1,1] = 10;
            Matriz.MostrarMatriz();
        
        }   


    }

}    

