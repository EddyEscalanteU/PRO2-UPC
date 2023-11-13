public class Cadena{
    //Propiedades
    public string Cad;

    //Contructor
    public Cadena(){
        Cad = "";
    }
    public Cadena(string myCadena)
    {
        Cad = myCadena;
    }

    public char ObtenerCaracter(int posicion)
    {
        if (posicion < Cad.Length) 
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
            console.WriteLine("Char: " + Cad[i]);
        }
    }
}