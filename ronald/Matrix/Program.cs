namespace Programacion2{
    public class Matrices{
        public static void Main(string[] args)
        {
            MatrizEnteros Matriz = new MatrizEnteros(4,4);

        //M.defaultvalue = 7;
            Matriz.CargarMatrizDefault();
            Matriz.MostrarMatriz();

            Console.WriteLine("------------------------------------");
            Matriz.M[2,1] = 2;              //opcion1
            Matriz.Insertar(2, 3, 6);       //opcion2
            Matriz.Insertar(0, 0, 1);
            Matriz.M[3,2] = 3;
            Matriz.M[3,0] = 7;
            Matriz.MostrarMatriz();
            Console.WriteLine("------------------------------------");
            Matriz.LlenarMatriz_V1();
            Matriz.MostrarMatriz();
            Matriz.LlenarMatriz_V2();
            Matriz.MostrarMatriz();
            Console.WriteLine("------------------------------------");
            Matriz.LlenarMatriz_V3();
            Matriz.MostrarMatriz();
            Matriz.LlenarMatriz_V4();
            Matriz.MostrarMatriz();
            Matriz.LlenarMatriz_V5();
            Matriz.MostrarMatriz();



        }
    }
}