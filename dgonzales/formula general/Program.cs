﻿using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int a = 10;
    int b = 100;
    int c = 10;
    
    int var1 = b * (-1);
    
    int aux = 4 * a * c;
    double var2 = Math.Sqrt((b*b) - (4 * a * c));
    int var3 = 2 * a;
    
    double x = (var1 - var2)/var3;
      
      Console.WriteLine(var1);
      Console.WriteLine(var2);
      Console.WriteLine(var3);
      
      Console.WriteLine(x);
    }
  }
}
