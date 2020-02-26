using System;

namespace NumbersInCSharp {
  class Program {
    static void Main (string[] args) {
      WorkingWithIntegers ();
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

      c = a + b - 12 * 17;
      Console.WriteLine ($"c is {c}");
    }
  }
}