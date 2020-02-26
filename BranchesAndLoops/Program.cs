using System;

namespace BranchesAndLoops {
  //https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops-local
  class Program {
    static void ExplorIf (string[] args) {
      int a = 5;
      int b = 1;
      if (a + b > 10) {
        Console.WriteLine ("Bigger than 10.");
      } else {
        Console.WriteLine ("Tinyier than 10.");
      }

      int c = 4;
      if ((a + b + c > 10) && (a == b)) {
        Console.WriteLine ("The answer is greater than 10" + "And the first number is equal to the second");
      } else {
        Console.WriteLine ("The answer is not greater than 10" + "or maybe the first num is not equal to the second");
      }
    }

    static void Main (string[] args) {
      int counter = 0;
      while (counter < 10) {
        Console.WriteLine ($"Hello World! The counter is {counter}");
        counter++;
      }

      for (int i = 0; i < 10; i++) {
        Console.WriteLine ($"FOR The counter is {i}");
      }
    }

  }
}