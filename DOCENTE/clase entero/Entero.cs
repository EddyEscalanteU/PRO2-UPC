public class Entero
{
    //Propiedades
    public int N;

    //Contructor
    public Entero()
    {
        N = 0;
    }

    public Entero(int num)
    {
        N = num;
    }

    //Metodos (Procedimientos/Funciones)
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

    public bool EsPar_Mejorado(){
        return (N % 2 == 0);
    }

}