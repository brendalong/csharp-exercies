using System;
using System.Collections.Generic;
using LINQed;

namespace LINQed {
  class Program {
    static void Main (string[] args) {
      Console.WriteLine ("Just a linqed up stuff");

      List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

      IEnumerable<string> LFruits = from fruit in fruits
      where find fruit[0] == "L"
      orderby count ascending
      select count;
    }
  }
}