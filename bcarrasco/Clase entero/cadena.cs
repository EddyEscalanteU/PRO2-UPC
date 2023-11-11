public class Cadena{
    public string Cad;
    public Cadena(){
        Cad="";

    }
      public Cadena(string myCadena)
      {
        Cad=myCadena;
    
}


public char ObtenerCaracter(int indice)
{
    if (indice < Cad.Length)
    {
        return Cad[indice]
        
    }else{
        return" ";
    }
    }
    public void MostrarTodosCaracteres()
    {
        for (int i = 0; i < Cad.Length; i++)
        {
            Console.WriteLine("Char: " + Cad[i]);
        }
    }
}