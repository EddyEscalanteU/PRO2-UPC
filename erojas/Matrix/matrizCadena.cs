public class MatrizCadenas{
    public string[,] M; //Elemento de la Matriz
    public int fila;//Cantidad de filas
    public int columna;//Cantidad de columnas
    public string defaultValue = "▒";//Valor por defecto

    //El constructor dandole la cantidad X y Y
    public MatrizCadenas(int cantX, int cantY)
    {
        //Dimensionar la matriz
        M = new string[cantX, cantY];
        columna = cantX;
        fila = cantY;
    }

    //Cargar la matriz con valores por defecto
    public void CargarMatrizDefault()
    {
        //Dar valores por defecto a la matriz
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[y, x] = defaultValue;
            }
        }
    }

    //Mostrar el contenido de la matriz
    public void MostrarMatriz()
    {
        string res = "";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                string dato = M[y, x];
                res = res + dato + ", ";
            }
            res = res + "\n";
        }
        Console.WriteLine(res);
    }
    
    public string Obtener(int posX, int posY )
    {
        return M[posX, posY];      
    }
    public void Insertar(int posX, int posY, string ele)
    {
        int cant = CantCaracteres(ele);
        string espacios = "";
        if(cant <= 7){
            int difCaracteres = 7 - cant;
            for(int i = 0; i < difCaracteres; i++){
                espacios = espacios + " ";
            }
        }
        M[posX, posY] = ele + espacios;
    }

    public int CantCaracteres(string dato){
        return dato.Length;
    }



    public void LlenarMatriz_v1()
    {
        int i = 1;
        string dato = "UPC";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
            }
            dato = dato + "_" + i;
            i++;
        }
    }
    public void MoverBlackPeon(int x, int y){     
            string peonAux = Obtener(x, y);
            Insertar(x, y, defaultValue);
            y = y - 1;
            Insertar(x, y, peonAux);
    }
    public void MoverWhitePeon(int x, int y){     
            string peonAux = Obtener(x, y);
            Insertar(x, y, defaultValue);
            y = y + 1;
            Insertar(x, y, peonAux);
    }
     public void MoverBlackAlfil(int x, int y, int cant, bool opcion){ 
        string alfilAux = Obtener(x, y);
        Insertar(x, y, defaultValue);

        if(opcion){
            x = x - cant;
            y = y - cant;
        }else{
            x = x + cant;
            y = y - cant;
        }
        Insertar(x, y, alfilAux);
    }
}