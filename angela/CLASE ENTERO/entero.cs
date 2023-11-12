public class Entero
{
//propiedades
public int N;

//constructor
public Entero()
{
    N = 0;
}
public Entero (int num)
{
    N = num;
}
//metodo (procedimiento/funcion)
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