public class Cadena{
    public string Cad;
    public Cadena(){
        Cad = " ";
    }
    public Cadena(string myCadena){
        Cad= myCadena;
    }
    public char obtenerCaracter(int posicion){
        if(posicion < Cad.Length)
        {
            return Cad[posicion];
        } else {
            return ' ';
        }

    }
    public void MostrarCaracteres()
    {
        for (int i = 0; i < Cad.Length; i++)
        {
            Console.WriteLine("Char: " + Cad[i]);
        }
    }
}