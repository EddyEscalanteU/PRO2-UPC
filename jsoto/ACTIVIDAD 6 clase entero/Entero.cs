public class Entero
{
    //promipedades
       public int N = 0; 

    //constructor
    public Entero(){
            N = 0;
        

    }

    public Entero(int num){
        N = num;
    }
    //metodos (procedimientos/ funciones)
     public bool EsPar()
    {
        if (N % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool Espar_Mejorado(){
        return (N % 2 == 0);

    }
    public bool EsMultiploN(int multiplo){
        return (N % multiplo == 0);
    }
    public void MostrarDigitos(){
         int NroAux = N;
        while (NroAux != 0)
        {
            int dig = NroAux % 10;
            Console.WriteLine("Dig: " + dig);
            NroAux = NroAux / 10;
        }
    }
}