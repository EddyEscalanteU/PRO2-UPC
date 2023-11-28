using System.Data;
// Aca se habia equivocado el docente y ase invertio ya que primero esta Y  despues X pero igual sirve o lo lee el c# ya que par este nose toma encuenta el orden si no la formula echa
public class MatrizEnteros
{

    //Elemeto de la matriz
    public int [,] M;

    //cantidad de filas
    public int fila;

    //cantidad de columnas
    public int columna;

    //valor por defecto 
    public int defaultValue = -1;

    // el constructor vacio
    public MatrizEnteros()
    {
        M = new int[0,0] ;
        fila = 0 ;
        columna = 0 ;
    }

    // El cosntructor dandole la cantidad en X y Y
    public MatrizEnteros (int cantX , int cantY)
    {
    // Dimensionar la matriz 

        M= new int [cantX,cantY];
        columna =  cantX;
        fila = cantY;
    }

    //Carga la matriz  con valores por defecto
    public void CargarMatrizDeafault()
    {
    // Dar valores por defecto ala matriz ya que aca estamos haciento una matriz de ceros (0) j seria X y k seria y

        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[y,x]=defaultValue;
            }
        }
    }

    // Mostrar el contenido de la matriz

    public void MostraMatriz()
    {
        string res ="";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                // El programa c# maneja al reves el orden de X y Y
                int dato = M[y,x];
                res = res + dato + " , " ;
            }

            res = res +"\n";
        }

        Console.WriteLine(res);
    }

    // aca como esta invertido las x y las y cambiamos la estrcutura con esta formula
    public void Insertar(int posX,int posY,int element)
    {
        M[posX,posY] = element;
    }

    public void LlenarMatriz_v1()
    {
        int dato =1;
                for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
                
            }
            dato = dato + 1;
        }
    }

    public void LlenarMatriz_v2()
    {
        int dato =1;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
                dato = dato + 1;
            }
        
        }
    }

        public void LlenarMatriz_v3()
    {
        // aca pusimos 16 por los espacios de la matriz dada que es e 4x4=16 es por eso ese numero
        int dato =16;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
                dato = dato - 1;
            }
        
        }
    }
        public void LlenarMatriz_v4()
    {
        
        int dato =4;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
                dato = dato - 1;
            }
            dato = 4 ;
        }
    }

    public void LlenarMatriz_v5()
    {
        
        int dato =4;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                M[x,y]= dato;
            }
            //aca saca esta formula fuera del formula de forn para poder tener en vertical del 4 al 1 osea al reves en la matriz
            dato = dato - 1;
        }
    }
// aca tenemos la forma triangulo inversea que empieza desde arriba hacia abajo con un matriz(5,5)
    public void LlenarMatrizTriangulo_v1()
    {
        // aca damos los valores que tendran en esa matriz con el cual se formara el triangulo son de forma 1
        //la forma esta dibujado en el cuaderno
        int triangulo = fila;
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                if(y < triangulo)
                {
                    M[x,y]= dato;
                }
                
            }
            triangulo++;
        }
    }


    public void LlenarMatrizTriangulo_v2()
    {
        // aca damos los valores que tendran en esa matriz con el cual se formara el triangulo son de forma 1
        //la forma esta dibujado en el cuaderno
        int triangulo = fila;
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                if(y < triangulo)
                {
                    M[x,y]= dato;
                }
                
            }
            triangulo--;
        }
    }

    public void LlenarMatrizTriangulo_v4()
    {
        // aca damos los valores que tendran en esa matriz con el cual se formara el triangulo son de forma 1
        //la forma esta dibujado en el cuaderno
        int triangulo = 1;
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                if(y >= triangulo - 1)
                {
                    M[x,y]= dato;
                }
                
            }
            triangulo++;
        }
    }

    public void LlenarMatrizTriangulo_v3()
    {
        // aca damos los valores que tendran en esa matriz con el cual se formara el triangulo son de forma 1
        //la forma esta dibujado en el cuaderno
        int triangulo = fila; // volvemos a poner fila 
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                if(y >= triangulo - 1)
                {
                    M[x,y]= dato;
                }
                
            }
            triangulo--;
        }
    }

        public void LlenarMatrizRectangulo_v1()
    {
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                if (y <(fila/2)+1)
                {
                    M[x,y]= dato;
                }
            
            }
        }
    }

    public void LlenarMatrizRectangulo_v2()
    {
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)
            {
                if (y >= (fila/2))
                {
                    M[x,y]= dato;
                }
            
            }
        }
    }

    public void LlenarMatrizRectangulo_v3()
    {
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            if (x <= (fila/2))
            {
                for (int y = 0; y < fila ; y++)            
                {
                    M[x,y]= dato;
                }
            
            }
        }
    }

    public void LlenarMatrizRectangulo_v4()
    {
        int dato = 7 ;
        for (int x = 0; x < columna ; x++)
        {
            if (x >= (fila/2))
            {
                for (int y = 0; y < fila ; y++)            
                {
                    M[x,y]= dato;
                }
            
            }
        }
    }

    public void MatrizSerie_MasUno()
    {
        int dato = 1;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)            
            {
                M[x,y]= dato;
                dato ++;
            }
        }
    }

    public void MatrizSerie_Masdos()
    {
        int dato = 1;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)            
            {
                M[x,y]= dato;
                dato = dato + 2;
            }
        }
    }

    public void MatrizSerie_MaselAnteriorDato()
    {   
        int datoPrevio = 0;
        int dato = 1;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)            
            {
                M[x,y]= dato;
                dato = datoPrevio + dato;
                datoPrevio = dato;
            }
        }
    }

        public void MatrizSerie_MaselAnteriorDato_2()
    {   
        int datoPrevioA = 0;
        int datoPrevioB = 1;
        int dato = 0;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)            
            {
                dato = datoPrevioA + datoPrevioB;
                M[x,y]= dato;

                datoPrevioA = datoPrevioB;
                datoPrevioB = dato;
            }
        }
    }

    public void MatrizSerie_MaselAnteriorDato_3()
    {   
        int datoPrevioA = 0;
        int datoPrevioB = 1;
        int datoPrevioC = 0;
        int dato = 0;
        for (int x = 0; x < columna ; x++)
        {
            for (int y = 0; y < fila ; y++)            
            {
                dato = datoPrevioA + datoPrevioB + datoPrevioC;
                M[x,y]= dato;

                datoPrevioA = datoPrevioB;
                datoPrevioB = datoPrevioC;
                datoPrevioC = dato ;
            }
        }
    }
}
