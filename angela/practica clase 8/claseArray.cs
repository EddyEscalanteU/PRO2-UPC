public class claseArray
//propiedades
public int[] ArrayEnteros;

//constructor
public claseArray(){
    ArrayEnteros = new int[0];
}

public claseArray(int cantidad){
    ArrayEnteros = new int[cantidad];
}
//metodos (procedimiento/funciones)
public void mostrarArray(){
    for (int i = 0; i < ArrayEnteros.length; i++)
    {
        console.WriteLine("posicion: " + i);
        Console.WriteLine(ArrayEnteros[i];)
        }
    }
    public void ordenmientoBurbuja()
        for (int i = 1; i <ArrayEnteros.length; i++)
        {
            for (int j = 0; j <= ArrayEnteros.length - 2 j++)
            {
                if (ArrayEnteros[j] > ArrayEnteros[j + 1])
                {
                    int aux =ArrayEnteros[j];
                    ArrayEnteros[j] = ArrayEnteros [j + 1];
                    ArrayEnteros[j + 1] = aux;
            }
        }

    }
    
}

public void inetercalarPrimeroUltimo()
{
    int n = ArrayEnteros.length
}

