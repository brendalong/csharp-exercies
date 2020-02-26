using System;
using System.Collections.Generic;

class MainClass
{

  public static void Main(string[] args)
  {

    Random myrandom = new Random();
    List<int> numbers = new List<int>(){
    myrandom.Next(16),
    myrandom.Next(16),
    myrandom.Next(16),
    myrandom.Next(16),
    myrandom.Next(16),
    myrandom.Next(16),
    };

    Console.WriteLine("mine", numbers);
    numbers.ForEach(num => Console.WriteLine(num));

    for (int i = 0; i < numbers.Count; i++)
    {

      // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
      if (numbers.Contains(i))
      {
        Console.WriteLine($"we're in {i}");
      }
      else
      {
        Console.WriteLine($"get lost {i}");
      };
    }
  }
}