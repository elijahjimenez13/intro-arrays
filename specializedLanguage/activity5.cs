using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int[] x = {11, 77, 22, 55, 33};
    int swapVal;
    int i;
    
    x[0] = 11;
    x[1] = 77;
    x[2] = 22;
    x[3] = 55;
    x[4] = 33;
    
    swapVal = x[0];
    x[0] = x[4];
    x[4] = swapVal;
    
    swapVal = x[1];
    x[1] = x[3];
    x[3] = swapVal;
    
    for (i = 0; i < x.Length; i++)
    {
    	Console.WriteLine(x[i] + " ");
    }
    }
  }
}