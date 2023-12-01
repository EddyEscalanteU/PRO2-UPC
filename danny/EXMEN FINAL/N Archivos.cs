﻿using System;
using System.IO;

class Program
{
    private static string[] ArrayCadenas;

    static void Main()
    {
        GenerarAbcdarioIntercaladoRecursivo();
        GenerarArchivo("resultado.txt");
        CrearNArchivos(5);
    }

    public static void GenerarAbcdarioIntercaladoRecursivo()
    {
        int cantAbcdario = (90 - 65) + 1;
        ArrayCadenas = new string[cantAbcdario];

        GenerarAbcdarioRecursivo(0, true);
    }

    private static void GenerarAbcdarioRecursivo(int indice, bool mayus)
    {
        if (indice < ArrayCadenas.Length)
        {
            int letraInicial;

            if (mayus)
            {
                letraInicial = 65 + indice;
            }
            else
            {
                letraInicial = 97 + indice;
            }

            char letra = (char)letraInicial;
            ArrayCadenas[indice] = letra + "";

            // Cambiar el estado para la próxima iteración
            GenerarAbcdarioRecursivo(indice + 1, !mayus);
        }
    }

    public static void MostrarArray()
    {
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            Console.WriteLine(ArrayCadenas[i]);
        }
    }

    public static void GenerarArchivo(string nombreArchivo)
    {
        File.WriteAllLines(nombreArchivo, ArrayCadenas);
        Console.WriteLine($"Archivo {nombreArchivo} generado con éxito.");
    }

    public static void CrearNArchivos(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string nombreArchivo = $"resultado_{i}.txt";
            GenerarArchivo(nombreArchivo);
        }
    }
}



                
             












