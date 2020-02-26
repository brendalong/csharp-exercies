using System;

namespace NumbersInCSharp {
  //https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp-local

  class Program {
    static void Main (string[] args) {
      WorkingWithIntegers ();
      OrderPrecedence ();
      TestLimits ();

      double radius = 2.50;
      double area = Math.PI * radius * radius;
      Console.WriteLine (area);
    }

    static void WorkingWithIntegers () {
      int a = 18;
      int b = 6;
      int c = a + b;
      Console.WriteLine (c);
      Console.WriteLine ("---------");
      // subtraction
      c = a - b;
      Console.WriteLine (c);
      Console.WriteLine ("---------");
      // multiplication
      c = a * b;
      Console.WriteLine (c);
      Console.WriteLine ("---------");
      // division
      c = a / b;
      Console.WriteLine (c);
      Console.WriteLine ("---------");
      // a combination
      c = a + b - 12 * 17;
      Console.WriteLine ($"c is {c}");
      Console.WriteLine ("----d----");
      int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
      Console.WriteLine (d);
    }

    static void OrderPrecedence () {
      int a = 5;
      int b = 4;
      int c = 2;
      int d = a + b * c;
      Console.WriteLine (d);

      d = (a + b) * c;
      Console.WriteLine (d);

      d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
      Console.WriteLine (d);

      int e = 7;
      int f = 4;
      int g = 3;
      int h = (e + f) / g;
      Console.WriteLine (h);
    }

    static void TestLimits () {
      int max = int.MaxValue;
      int min = int.MinValue;
      Console.WriteLine ($"The range of integers is {min} to {max}");

      int what = max + 3;
      Console.WriteLine ($"An example of overflow: {what}");
    }

  }
}