﻿public void GenerarAbcdarioIntercalado()
{
    int cantAbcdario = (90 - 65) + 1;
    ArrayCadenas = new string[cantAbcdario];
    
    GenerarAbcdarioRecursivo(0, true);
    
    MostrarArray();
}

private void GenerarAbcdarioRecursivo(int posicion, bool mayus)
{
    if (posicion < ArrayCadenas.Length)
    {
        int letraInicial;
        
        if (mayus)
        {
            letraInicial = 65 + posicion;
        }
        else
        {
            letraInicial = 97 + posicion;
        }

        char letra = (char)letraInicial;
        ArrayCadenas[posicion] = letra + "";

        GenerarAbcdarioRecursivo(posicion + 1, !mayus);
    }
}



                
             












