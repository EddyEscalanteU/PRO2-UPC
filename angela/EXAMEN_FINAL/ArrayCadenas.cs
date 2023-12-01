
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








public void GenerarSerieExamenIterativo(int numA, int numB, int cantidadElementos)
{
    bool sw = true;

    while (cantidadElementos > 0)
    {
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
    }
}
