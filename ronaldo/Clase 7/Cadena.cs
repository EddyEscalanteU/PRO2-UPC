public class Cadena
{
    public string Cad;

    public Cadena(string MyCadena)
    {
        Cad = MyCadena ;
    }
// UPC
    public char ObtenerCaracter(int posicion)
    {
        if( posicion <= Cad.Length)
    {
        return Cad[posicion];
        }
        else 
        {
        return ' ';
        }
    } 

    public void MostrarCaracteres()
    {
        for (int i = 0; i < Cad.Length; i++)
        {
            Console.WriteLine("char: " + Cad[i]);
        }
    }

}