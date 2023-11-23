namespace Programacion2{
    public class Matrices{
        public static void Main(string[] args)
        {
            MatrizEnteros M = new MatrizEnteros(4,4);

            //M.defaultValue = 7;
            M.CargarMatrizDefault();

            M.MostrarMatriz();
        }
    }
}