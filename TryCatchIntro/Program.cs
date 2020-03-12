using System;

namespace TryCatchIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.Write("what is bank difficulty");
      //var userInput = Console.ReadLine();

      // var burrito = 0;
      // var taco = 100 / (3 * burrito);

      int difficulty = 0;

      while (true)
      {
        try
        {
          Console.Write("what is bank difficulty");
          var userInput = Console.ReadLine();
          difficulty = int.Parse(userInput);
          break;
        }
        //this is default
        catch (System.Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        // //can add many catches
        // catch(System.DividedByZeroException){

        // }
      }
    }

  }
}