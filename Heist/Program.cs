using System;
using System.Collections.Generic;

namespace Heist
{

  class Program
  {

    static void Main(string[] args)
    {
      // let's make a list that can potentially hold members of the team
      List<Dictionary<string, string>> ListOfTeamMembers = new List<Dictionary<string, string>>();
      Console.WriteLine("------------------------");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.Red;
      Console.WriteLine("Plan Your Heist");
      Console.ResetColor();
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.Magenta;
      // Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("What level of Bank difficulty would you like?");
      Console.ResetColor();

      int bankDifficulty = int.Parse(Console.ReadLine()); //default

      bool addAnother = true;
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("------Build Your Team------");
      Console.ResetColor();
      while (addAnother)
      {
        Console.WriteLine("Member's Alias?");
        string userName = Console.ReadLine();
        if (userName == "")
        {
          addAnother = false;
        }
        else
        {
          Dictionary<string, string> TeamMember = new Dictionary<string, string>();

          TeamMember.Add("userName", userName);
          Console.WriteLine($"Rank {userName}'s talents: (1 - 5)");
          string userSkill = Console.ReadLine();
          TeamMember.Add("skillLevel", userSkill);
          // int userSkill = int.Parse(Console.ReadLine());
          Console.WriteLine($"What is {userName}'s courage level?(0.0 - 2.0)");
          string userCourage = Console.ReadLine();
          TeamMember.Add("courageFactor", userCourage);
          // int userCourage = int.Parse(Console.ReadLine());
          ListOfTeamMembers.Add(TeamMember);

          // Console.WriteLine($"You have been accepted {ListOfTeamMembers[0]["userName"]}");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine($"{userName} is now a member of your team. Good LUCK.");
          Console.ResetColor();
        }
      }

      //Display the team member's information.
      int i = 1;
      foreach (var member in ListOfTeamMembers)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"------Member {i}---------");
        Console.ResetColor();
        foreach (KeyValuePair<string, string> prop in member)
        {
          Console.WriteLine($"* {prop.Key.ToUpper()}: {prop.Value}");
        }
        i++;
      }

      Console.WriteLine($"-----------------------");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("So, how many times would you like to attempt a robbery?");
      Console.ResetColor();
      int howManyAttempts = int.Parse(Console.ReadLine());


      int teamSkill = 0; //default value
      int attemptCount = 0;

      int failedAttemp = 0;

      foreach (var member in ListOfTeamMembers)
      {
        teamSkill = teamSkill + int.Parse(member["skillLevel"]);
      }

      while (attemptCount < howManyAttempts)
      {
        Console.ResetColor();
        Console.WriteLine($"--- Attempt Number: {attemptCount + 1}");

        bankDifficulty = bankDifficulty;//reset
        //Add some random difficulty to the bank
        Random rand = new Random();
        int addedDifficulty = rand.Next(-10, 10);
        bankDifficulty = bankDifficulty + addedDifficulty;

        if (teamSkill > bankDifficulty)
        {
          if (failedAttemp > 0)
          {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"After {failedAttemp} failed attempts, 💰 MILLIONS ARE YOURS 💰");
          }
          else
          {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Great Work on the first try, 💰 MILLIONS ARE YOURS 💰");
          }
          break;
        }
        else
        {
          failedAttemp++;
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("🚨 OOPS, Get out of there. 🚔");
        }
        attemptCount++;
      }
      Console.ResetColor();
      Console.WriteLine("------Summary------");
      Console.WriteLine($"Team Skill: {teamSkill}");
      Console.WriteLine($"Final Bank Difficulty: {bankDifficulty}");


    }

  }
}