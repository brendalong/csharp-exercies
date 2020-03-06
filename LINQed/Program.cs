using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQed
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Just some linq-ed up stuff");

      List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

      IEnumerable<string> LFruits = from fruit in fruits
      where fruit.StartsWith('L')
      select fruit;

      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
      {
        15,
        8,
        21,
        24,
        32,
        13,
        30,
        12,
        7,
        54,
        48,
        4,
        49,
        96
      };

      IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
      {
        "Heather",
        "James",
        "Xavier",
        "Michelle",
        "Brian",
        "Nina",
        "Kathleen",
        "Sophia",
        "Amir",
        "Douglas",
        "Zarley",
        "Beatrice",
        "Theodora",
        "William",
        "Svetlana",
        "Charisse",
        "Yolanda",
        "Gregorio",
        "Jean-Paul",
        "Evangelina",
        "Viktor",
        "Jacqueline",
        "Francisco",
        "Tre"
      };

      List<string> descend = (from name in names orderby name descending select name).ToList();
      IEnumerable<string> descend2 = names.OrderByDescending(name => name);

      // Build a collection of these numbers sorted in ascending order
      List<int> numberList = new List<int>()
      {
        15,
        8,
        21,
        24,
        32,
        13,
        30,
        12,
        7,
        54,
        48,
        4,
        49,
        96
      };

      IEnumerable<int> numberListAscending = numberList.OrderByDescending(num => num);

      //----------------------------- //
      // Output how many numbers are in this list
      List<int> howmanyNumbers = new List<int>()
      {
        15,
        8,
        21,
        24,
        32,
        13,
        30,
        12,
        7,
        54,
        48,
        4,
        49,
        96
      };

      Console.WriteLine($"Howmany Nums {howmanyNumbers.Count}");

      // How much money have we made?
      //m stands for decimal
      List<decimal> purchases = new List<decimal>
      {
        2340.29m,
        745.31m,
        21.76m,
        34.03m,
        4786.45m,
        879.45m,
        9442.85m,
        2454.63m,
        45.65m
      };

      Console.WriteLine($"All the Money {purchases.Sum()}");
      // decimal sum = (from x in purchases select x).Sum();
      //for each multiply by 100 to remove decimal then add together(sum) then
      //divide by 100

      List<double> purchases2 = new List<double>
      {
        2340.29,
        745.31,
        21.76,
        34.03,
        4786.45,
        879.45,
        9442.85,
        2454.63,
        45.65
      };
      IEnumerable<double> allNumbs = from count in purchases2
      select count * 100;

      var allMoneyAgain = Math.Round(allNumbs.Sum() * .01, 2);

      List<double> prices = new List<double>()
      {
        879.45,
        9442.85,
        2454.63,
        45.65,
        2340.29,
        34.03,
        4786.45,
        745.31,
        21.76
      };

      Console.WriteLine($"Max Value is {prices.Max()}");

      List<int> wheresSquaredo = new List<int>()
      {
        66,
        12,
        8,
        27,
        82,
        34,
        7,
        50,
        19,
        46,
        81,
        23,
        30,
        4,
        68,
        14
      };
      /*
          Store each number in the following List until a perfect square
          is detected.

          Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 }

          Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
      */

      //first write out to determine is sqrRoot
      int testVal = 1;
      if (testVal == 0 || testVal == 1)
      {
        Console.WriteLine($"The Test Val {testVal} has No SquareRoot");
      }

    }
  }
}