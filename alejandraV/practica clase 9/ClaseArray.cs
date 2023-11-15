public class ClaseArray{
    string[] ArrayEnteros;

    public ClaseArray(){
        ArrayEnteros = new string[0];
        
    }

    public ClaseArray(int cant){
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray(){
        string resp= "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
    }
}