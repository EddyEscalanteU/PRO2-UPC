public class Entero{
    //Proiedades
    int N;
    //Constructor
    public Entero(){
        N=0;
    }
    public Entero(int num){
        N = num;
    }
    //Metodos (Procedimientos/Funciones)
    public bool Espar(){
        if(N % 2 == 0)
        {
            return true;
        }else{
            return false;
        }
    }
    public bool Espar_Mejorado(){
        return (N % 2 == 0);
    }
    public bool EsMultiploN(int multiplo){
        return(N % multiplo == 0);
    }
    public void MostrarDigitos(){
        int NroAux = N;
        while(NroAux != 0){
            int dig = NroAux % 10;
            Console.WriteLine("Dig: " + dig);
            NroAux = NroAux / = 10;
        }
        Console.
    }
     public void MostrarDigPares()
    {
        int NroAux = N;
        while (NroAux != 0)
        {
            int dig = NroAux % 10;
            if (dig % 2 == 0)
            {
                Console.WriteLine("Dig: " + dig);
            }
            NroAux = NroAux / 10;
        }
    }

}

