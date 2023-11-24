using System.Numerics;

public class ArrayEntero{
public int[] Numeros;

//CONSTRUCTOR
public ArrayEntero(){
 Numeros = new int[0];
}
public ArrayEntero(int valor){
     Numeros = new int[valor];
}
public void MostrArarray(){
    for (int i = 0; i < Numeros.Length; i++)
    {
        Console.WriteLine(Numeros[i]);
    }
}
public void MostrarNumeroMayor(){
    
  for (int i = 0; i < Numeros.Length; i++)
  {
    if(Numeros.Length >= 0){
        Console.WriteLine(" numero minimo es el: " + Numeros[0]);
    }
  } 
    
  }
    
        
    }


