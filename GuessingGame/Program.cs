using System;

//https://gist.github.com/AdamSheaffer/3b6058bf62fd587d71fefcc4e09b0fa0

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rand = new Random();
      int secretNumber = rand.Next(1, 10);

      // for (int i = 0; i < 3; i++) {
      while (true)
      {
        Console.WriteLine("Guess a number between 1 and 10");
        string userGuess = Console.ReadLine();
        int userGuessInt = int.Parse(userGuess);

        if (userGuessInt == secretNumber)
        {
          Console.WriteLine($"You guessed it! It was {secretNumber}");
          break;
          // return;
        }
        else
        {
          Console.WriteLine($"Nope, try again");
        }
      }
    }

  }
}