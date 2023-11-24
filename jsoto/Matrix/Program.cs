namespace Programacion2
{
    public class Matrices
    {
        public static void Main(string[] args)
        {
            //MatrizEnteros Matriz = new MatrizEnteros(5, 5);
            //Matriz.defaultValue = 0;
            //Matriz.CargarMatrizDefault();
            //Matriz.MostrarMatriz();
            /*
            Console.WriteLine("---------------------------");
            Matriz.M[2, 1] = 5;         //opcion 1
            // Matriz.Insertar(2, 1, 5);   //opcion 2
            Matriz.M[3,2] = 3;
            Matriz.M[3, 0] = 7;
            Matriz.M[1, 3] = 3;
            Matriz.M[0, 2] = 2;
            Matriz.M[2, 2] = 5;
            Matriz.M[1, 2] = 9;
            Matriz.M[3, 1] = 2;
            Matriz.M[1, 0] = 3;
            Matriz.Insertar(2, 3, 6);
            Matriz.Insertar(0, 0, 1);
            Matriz.M[2, 0] =5;
            Matriz.M[1, 1] =5;
            Matriz.M[0, 3] =1;
            Matriz.M[0, 1] =3;
            Matriz.M[3, 3] =5;
            Matriz.MostrarMatriz();
            Console.WriteLine("---------------------------");
            //Matriz.LlenarMatriz_v1();
            //Matriz.MostrarMatriz();
            */
            //Console.WriteLine//("---------------------------");
            //Matriz.MatrizSerie_Domino();
            //Matriz.MostrarMatriz();
            //Console.WriteLine("---------------------------");
            MatrizCadenas MC = new MatrizCadenas(8, 8);
            MC.CargarMatrizDefault();
            //MC.LlenarMatriz_v1();
            //MC.Insertar(0, 0, "Torre");
            for(int i = 0; i < 4; i++){
                //Serie X
                int x = 0;
                if(i < 2){
                    x = 0;
                }else{
                    x = 7;
                }

                //Serie Y
                int y = 0;
                if(i == 0 || i == 3){
                    y = 0;
                }else{
                    y = 7;
                }
                //Console.WriteLine(x +  " --- " + y);
                MC.Insertar(x, y, "Torre");
            }
            MC.Insertar(2, 0, "Alfil");
            MC.Insertar(4, 7, "Reyna");
            MC.Insertar(3, 0, "Reyna");
            for(int i = 0; i < 8; i++){
               MC.Insertar(i, 6, "Peon");
           }
            MC.Insertar(0, 1, "Peon");
            MC.Insertar(1, 1, "Peon");
            MC.Insertar(2, 1, "Peon");
            MC.Insertar(3, 1, "Peon");
            MC.Insertar(4, 1, "Peon");
            MC.Insertar(5, 1, "Peon");
            MC.Insertar(6, 1, "Peon");
            MC.Insertar(7, 1, "Peon");
            MC.Insertar(4, 0, "Rey");

           MC.Insertar(3, 7, "Rey");

            MC.Insertar(1, 0, "Caballo");
            MC.Insertar(6, 0, "Caballo");
            MC.Insertar(1, 7, "Caballo");
            MC.Insertar(6, 7, "Caballo");


            MC.MostrarMatriz();



        }
    }
}