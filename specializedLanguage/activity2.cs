using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] oldestPeople = {0, 0, 0, 0, 0};
      int nthPerson;
      int personAge;
      
      // Dead 1997 in France
      oldestPeople[0] = 122;
      
      // Dead 1999 in US
      oldestPeople[1] = 119;
      
      // Dead 1993 in US
      oldestPeople[2] = 117;
      
      // Dead 1998 in Canada
      oldestPeople[3] = 117;
      
      // Dead 2006 in Ecuador
      oldestPeople[4] = 116;
      
      nthPerson = 4;
      personAge = 0;
      
      if ((nthPerson >= 1) && (nthPerson <= 5))
      {
      	personAge = oldestPeople[nthPerson - 1];
      }
      
      Console.WriteLine(nthPerson + "th oldest person died at age " + personAge);
    }
  }
}