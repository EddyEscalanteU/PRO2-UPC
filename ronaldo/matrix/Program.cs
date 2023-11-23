namespace Programacion2
{
    public class Matrices
    {
        public static void  Main(string[] args)
        {
            // Aca lo llamamos y decimos que lo queremos de 4 columnas y 4 filas (4,4);
            MatrizEnteros M = new MatrizEnteros(4,4);
            M.defaultValue = 7;
            M.CargarMatrizDeafault();
            M.MostraMatriz();
        }
    }
}