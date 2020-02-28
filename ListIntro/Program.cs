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

      Dictionary<string, string> student = new Dictionary<string, string>();
      student.Add("name", "Adam");
      student.Add("Cohort", "Day 37");

      Dictionary<string, string> anotherStudent = new Dictionary<string, string>() { { "name", "Brenda" }, { "Cohort", "Day 37" },
      };

      foreach (KeyValuePair<string, string> item in student) {
        Console.WriteLine($"the student {item.Key} is {item.Value}");
      }

    }
  }
}