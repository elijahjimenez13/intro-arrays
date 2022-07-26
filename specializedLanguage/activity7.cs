using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int[] userVals = {10, 30, -5, 15, 1};
    int i;
    int sumVal;
    
    sumVal = 0;
    
    for (i = 0; i < userVals.Length; i++)
    {
    	sumVal = sumVal + userVals[i];
    }
    
    Console.WriteLine("Sum: " + sumVal);
    }
  }
}