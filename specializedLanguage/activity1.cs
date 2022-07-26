using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] itemCounts = {25, 99, 0};
      
     itemCounts[2] = itemCounts[0] *2; Console.WriteLine(itemCounts[2]);
    }
  }
}