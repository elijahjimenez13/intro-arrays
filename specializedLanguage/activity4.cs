using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int x;
    int y;
    int tmpVal;
    
    x = 10;
    y = 20;
    
    // Swap x and y
    tmpVal = x;
    x = y;
    y = tmpVal;
    
    Console.WriteLine(x + " " + y + "\n");
    }
  }
}