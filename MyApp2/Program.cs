using System;
using System.Collections.Generic;

namespace MyApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      string greeting = "Hello World";
      int numberTacos = 12;
      bool hasMeat = true;
      // string[] tacoFlavors = ["cheese", "chicken", "beef"];
      //but hey arrays are dead to us so lets use...
      List<string> tacoFlavors = new List<string>() { "cheese", "chicken", "beef" };

      for (int i = 0; i < tacoFlavors.Count; i++)
      {
        Console.WriteLine(tacoFlavors[i]);
      }

      foreach (var item in tacoFlavors)
      {
        Console.WriteLine("foreach " + item);
      }

      if (numberTacos > 5)
      {
        Console.Write("woa thats a lot of tacos");
      }
      else
      {
        Console.WriteLine("eat more tacos")
      }

      Console.WriteLine($"{greeting} I'd like {numberTacos} tacos and meat={hasMeat}");
    }
  }
}
