using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int[] userVals = {0, 0, 0, 0, 0};
    int i;
    
    for (i = 0; i < userVals.Length; i++)
    {
    	// Do something with element
        userVals[i] = -1;
    }
    for (i = 0; i < userVals.Length; i++)
    {
    	Console.WriteLine(userVals[i] + " ");
    }
    }
  }
}