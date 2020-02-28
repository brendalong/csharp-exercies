using System;
using System.Collections.Generic;

namespace ListIntro {
  class Program {
    static void Main(string[] args) {
      List<string> nssCohorts = new List<string> {
        "Cohort 36",
        "Cohort 37",
        "Cohort 38"
      };

      nssCohorts.Add("Cohort 39");

      List<int> birdYears = new List<int> {
        1996,
        2001,
        1842
      };

      birdYears.Add(2000);

      foreach (var item in nssCohorts) {
        Console.WriteLine(item);
      }

      birdYears.Remove(1996);

      foreach (var year in birdYears) {
        Console.WriteLine(year);

        if (year == 1996) {
          Console.WriteLine("Holden was born");
        } else {
          Console.WriteLine("no no");
        }
      }

      Console.WriteLine("Hello World!");
    }
  }
}