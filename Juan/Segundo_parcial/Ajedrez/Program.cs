class Program
{
    static void Main(string[] args)
    {
        MatrizCadenas MC = new MatrizCadenas(8, 8);
        MC.CargarMatrizDefault();

        // Insertar fichas blancas en las filas 0, 1 y 2
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if ((i + j) % 2 == 1)
                {
                    MC.Insertar(j, i, "blanco");
                }
            }
        }

        // Insertar fichas rojas en las filas 5, 6 y 7
        for (int i = 5; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    MC.Insertar(j, i, "rojo");
                }
            }
        }

        MC.MostrarMatriz();
    }
}
