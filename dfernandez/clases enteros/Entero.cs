using System.Security.Cryptography.X509Certificates;

public class Enteros{
    //Propiedades
    
    public int N;

    //Constructor

    public Enteros(){
        N = 0;

    }

    public Enteros(int num){
        N = num;
    }

    //Metodos (Procedimientos/Funciones)

    public bool EsPar(){

        if (N % 2 == 0){
            return true;
        }
        else
        {
            return false;

        }

    }

    public bool EsPar_Mejorado(){
        return (N % 2 == 0);

    }
    public bool EsMultiploN(int multiplo){
        return (N % multiplo == 0);
    }

    public void MostrarDigitos(){
        int NroAux = N;
        while(NroAux != 0)
        {
            int dig = NroAux % 10;
            Console.WriteLine("Dig; " + dig);
            NroAux = NroAux / 10;
        }
        
    }

    public void MostrarDigPares()
    {
        int NroAux = N;
        while (NroAux != 10)
        {
            int dig = NroAux % 10;
            if (dig % 2 == 0)
            
            Console.WriteLine("DIg: " + dig);

        }
        NroAux = NroAux / 10;
    }

}