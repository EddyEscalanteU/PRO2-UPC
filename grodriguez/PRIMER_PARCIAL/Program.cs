﻿using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		
		MostrarMaxMinArrayEnteros();
		
		int sum = SumaArrayEnteros();
		Console.WriteLine("La suma es " + sum);
		
		int promedio = PromedioArrayEnteros();
		Console.WriteLine("El promedio es " + promedio);
		
		string elemento = "España";
		string existe =  BuscarElementoArrayCadenas(elemento);
		Console.WriteLine("El elemento " + elemento + " " + existe);
		
		int numero = 6;
		int frecuencia = FrecuenciaArrayEnteros(numero);
		Console.WriteLine("El elemento " + elemento + " se repite " + frecuencia);
	}
	
	public static void MostrarMaxMinArrayEnteros(){
		int[] arr = { 8, 3, 5, -1, 2 };
 
        Console.WriteLine("Minimum number is " + arr.Min());
        Console.WriteLine("Maximum number is " + arr.Max());
	}
	
	public static int SumaArrayEnteros(){
		int[] array = { 1, 2, 3, 4, 5 };
 
        int sum = array.Sum();
        return sum;
	}
	
	public static int PromedioArrayEnteros(){
		int sum = SumaArrayEnteros();
		return sum / 2 ;
	}
	
	public static string BuscarElementoArrayCadenas(string elemento){
		string[] ciudad = { "Madrid", "Barcelona" };
		string existeEnArray = "false";
		for(int i = 0; i < ciudad.Length; i++){
			if(ciudad[i] == elemento){
				existeEnArray = "true";
			}
		}
		return existeEnArray;
	}
	
	public static int FrecuenciaArrayEnteros(int elemento){
		int numero = 0;
		int[] array = { 1,1,1,1, 2,2,2,2, 3, 4, 5 };
		for(int i = 0; i < array.Length; i++){
			if(array[i] == elemento){
				numero = 1;
				for(int j = 0; j < array.Length; j++){
					if(array[j] == elemento){
						numero = numero +1;
					}
				}
			}
		}
		return numero;
	}
	
	
}