public class Recursivo
{
    private string[] ArrayCadenas = new string[10];

    public void GenerarSerieExamenRecursivo(bool sw, int numA, int numB, int cantidadElementos)
    {
        if (cantidadElementos == 0)
        {
            return;
        }

        if (sw)
        {
            ArrayCadenas[10 - cantidadElementos] = numA + "";
            numA *= 10;
            sw = false;
        }
        else
        {
            ArrayCadenas[10 - cantidadElementos] = numB + "";
            numB += 100;
            sw = true;
        }
        cantidadElementos--;
        GenerarSerieExamenRecursivo(sw, numA, numB, cantidadElementos);
    }

    public string[] ObtenerArrayCadenas()
    {
        return ArrayCadenas;
    }
}
