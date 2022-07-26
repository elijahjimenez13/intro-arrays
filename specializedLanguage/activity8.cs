using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int[] userVals = {7, -9, 55, 44};
    int i;
    int maxVal;
    
    // Largest so far
    maxVal = userVals[0];
    
    for (i = 0; i < userVals.Length; i++)
    {
    	if (userVals[i] > maxVal)
        {
        	maxVal = userVals[i];
        }
    }
    
    Console.WriteLine("Max: " + maxVal);
    }
  }
}