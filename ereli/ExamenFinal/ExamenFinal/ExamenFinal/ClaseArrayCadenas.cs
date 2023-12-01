using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClaseArrayCadenas
{
    public string[] ArrayCadenas;

    public ClaseArrayCadenas()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArrayCadenas(int cant)
    {
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    /*
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
    */

    public string[] GenerarSerieExamenFinal(int cantidadElementos)
    {
        int numA = 5;
        int numB = 10;
        bool sw = true;
        for (int i = 0; i < cantidadElementos; i++)
        {
            if (sw)
            {
                ArrayCadenas[i] = numA + "";
                numA *= 10;
                sw = false;
            }
            else
            {
                ArrayCadenas[i] = numB + "";
                numB += 100;
                sw = true;
            }
        }
        return ArrayCadenas;
    }
}
