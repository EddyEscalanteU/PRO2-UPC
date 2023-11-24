namespace Programacion2
{
    public class Matrices
    {
        public static void  Main(string[] args)
        {
            //MatrizEnteros Matriz = new MatrizEnteros(5,5);
            //Matriz.defaultValue = 0;
            //Matriz.CargarMatrizDeafault();
            //Matriz.MostraMatriz();

            /*

            Console.WriteLine("---------------------------");

            //Estas son 2 formas de llamar a la matriz//Estas son 2 formas de llamar a la matriz
            //Matriz.M[2,1] = 5 ;       // opcion 1
            //Matriz.Insertar(2,1,5);  // opcion 2
            Matriz.M[2,1] = 5 ;
            Matriz.M[3,0]=7;
            Matriz.M[1,3]=3;
            Matriz.M[0,2]=2;
            Matriz.M[2,2]=5;
            Matriz.M[1,2]=9;
            Matriz.M[3,1]=2;
            Matriz.M[1,0]=3;
            Matriz.M[2,0]=5;
            Matriz.M[1,1]=5;
            Matriz.M[0,3]=1;
            Matriz.M[0,1]=3;
            Matriz.M[3,2]=3;
            Matriz.M[3,3]=5;
            Matriz.Insertar(2,3,6);
            Matriz.Insertar(0,0,1);
            Matriz.MostraMatriz(); 
            
            Console.WriteLine("---------------------------");
            
            Matriz.LlenarMatriz_v1();
            Matriz.MostraMatriz(); 

            Console.WriteLine("---------------------------");

            Matriz.LlenarMatriz_v2();
            Matriz.MostraMatriz(); 

            Console.WriteLine("---------------------------");
// aca seria  como la version 2 pero este cuenta del 1 dependiendo la matriz pero comienza al reves 
            Matriz.LlenarMatriz_v3();
            Matriz.MostraMatriz();

            Console.WriteLine("---------------------------");

            Matriz.LlenarMatriz_v4();
            Matriz.MostraMatriz();

            Console.WriteLine("---------------------------");

            Matriz.LlenarMatriz_v5();
            Matriz.MostraMatriz();

            Console.WriteLine("---------------------------");
            */

            //Console.WriteLine("---------------------------");

           // Matriz.LlenarMatrizTriangulo_v1();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.LlenarMatrizTriangulo_v2();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.LlenarMatrizTriangulo_v4();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.LlenarMatrizTriangulo_v3();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.LlenarMatrizRectangulo_v1();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.LlenarMatrizRectangulo_v2();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.LlenarMatrizRectangulo_v4();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.MatrizSerie_MasUno();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.MatrizSerie_Masdos();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.MatrizSerie_MaselAnteriorDato();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.MatrizSerie_MaselAnteriorDato_2();
            //Matriz.MostraMatriz();

            //Console.WriteLine("---------------------------");

            //Matriz.MatrizSerie_MaselAnteriorDato_3();
            //Matriz.MostraMatriz();
            
            MatrizCadenas MC = new MatrizCadenas(8,8);
            MC.CargarMatrizDeafault();
            //MC.LlenarMatriz_v1();
            //MC.Insertar(0, 0 ,"Torre");
            for (int i = 0; i < 4; i++)
            {
                MC.Insertar(1, 0 , "Torres");
            }
            MC.Insertar(1, 0 ,"caballlo");
            MC.Insertar(2, 0 , "Alfil");
            MC.Insertar(4, 7 , "Reyna");
            MC.Insertar(3, 0 , "Reyna");

            for (int i = 0; i < 8 ; i++)
            {
                MC.Insertar(i,6,"Peon");
            }
            MC.Insertar(0, 1 ,"Peon");
            MC.Insertar(1, 1 ,"Peon");
            MC.Insertar(2, 1 ,"Peon");
            MC.Insertar(3, 1 ,"Peon");
            MC.Insertar(4, 1 ,"Peon");
            MC.Insertar(5, 1 ,"Peon");
            MC.Insertar(6, 1 ,"Peon");
            MC.Insertar(7, 1 ,"Peon");

            MC.Insertar(3, 7 ,"Rey");



            MC.MostraMatriz();


}

    }
}