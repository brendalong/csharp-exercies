using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistPartII
{
  //https://gist.github.com/AdamSheaffer/c7563b750ab767f2123fd868e022dc67
  class Program
  {
    static List<IRobber> crew = new List<IRobber>();

    static void printCrew(){
      Console.Clear();
      Console.WriteLine("-------- Your Crew ---------");
      foreach (var member in crew){
        Console.WriteLine($"{member.ToString()}");
      }
      Console.WriteLine("----------------------------");
    }

    static void printRolodex(List<IRobber> rolodex, bool isChoosing = false){
      Console.WriteLine("---- Available Robbers -----");
      int counter = 1;
      foreach (var entry in rolodex){
        if (crew.Contains(entry)){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"{counter}. NOT AVAILABLE {entry.ToString()}");
          Console.ResetColor();
        }else{
          Console.WriteLine($"{counter}. {entry.ToString()}");
        }
        counter++;
      }
      if(!isChoosing){
        Console.WriteLine("Choose Another?");
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to HEIST II");

      List<IRobber> rolodex = new List<IRobber>();
      //  Name SkillLevel PercentageCut
      rolodex.Add(new Hacker{Name="Brenda", SkillLevel=5, PercentageCut=25});
      rolodex.Add(new Hacker{Name="John", SkillLevel=3, PercentageCut=15});
      rolodex.Add(new LockSpecialist{Name="Bell", SkillLevel=8, PercentageCut=30});
      rolodex.Add(new LockSpecialist{Name="Bonne", SkillLevel=2, PercentageCut=5});
      rolodex.Add(new Muscle{Name="Jack", SkillLevel=7, PercentageCut=20});
      rolodex.Add(new Muscle{Name="Ben", SkillLevel=3, PercentageCut=10});

      

      Console.WriteLine($"There are currently {rolodex.Count} robbers in the rolodex");

      bool addAnother = true;
      while(addAnother){
        
        Console.WriteLine("Add a new robber. Name > ");
        string robberName = Console.ReadLine();
        if (robberName == ""){
          addAnother = false;
        }else {
          Console.Clear();
          Console.WriteLine($"What is {robberName}'s specialty?");
          Console.WriteLine("1. Hacker (Disables alarms)");
          Console.WriteLine("2. Muscle (Disarms guards)");
          Console.WriteLine("3. Lock Specialist (Cracks vault)");
          string specialtyInput = Console.ReadLine();
          Console.Clear();
          Console.WriteLine($"What is {robberName}'s skill level? (1-100)");
          int skillInput = int.Parse(Console.ReadLine());

          Console.Clear();
          Console.WriteLine($"What is {robberName}'s cut of a job?");
          int cutInput = int.Parse(Console.ReadLine());

            if (specialtyInput == "1"){
              rolodex.Add(new Hacker{Name=robberName, SkillLevel=skillInput, PercentageCut=cutInput});
            }else if (specialtyInput == "2"){
                rolodex.Add(new Muscle{Name=robberName, SkillLevel=skillInput, PercentageCut=cutInput});
            }else {
              rolodex.Add(new LockSpecialist{Name=robberName, SkillLevel=skillInput, PercentageCut=cutInput});
            }
          Console.Clear();
        }
      }

      Bank GreenBank = new Bank();
      //mabe move to Bank
      //put values into meaningful type - like Dictionary?
      //use orderby to sort
      //get first item and last item
      Dictionary<string, int> bankValues = new Dictionary<string, int>(){
        {"Alarm", GreenBank.AlarmScore},
        {"Security", GreenBank.SecurityGuardScore},
        {"Vault", GreenBank.VaultScore}
      };

      var sortedBankValues = bankValues.OrderBy(bank => bank.Value);

      // foreach (KeyValuePair<string, int> prop in sortedBankValues)
      // {
      //   Console.WriteLine($"* {prop.Key.ToUpper()}: {prop.Value}");
      // }
      //   Console.WriteLine($"Least Secure: {sortedBankValues.First().Key} {sortedBankValues.First().Value}");
      //   Console.WriteLine($"Most Secure: {sortedBankValues.Last().Key} {sortedBankValues.Last().Value}");
      Console.Clear();
      Console.WriteLine($"The {sortedBankValues.First().Key} is the least secure.");
      Console.WriteLine($"The {sortedBankValues.Last().Key} is the most secure.");

      // int counter = 1;
      // foreach (var entry in rolodex){
      //   Console.WriteLine($"{counter}. {entry.ToString()}");
      //   counter++;
      // }

      printRolodex(rolodex, true);

      //List<IRobber> crew = new List<IRobber>();

      Console.WriteLine(@"------ Now it's time to make a crew ---------
      Choose your team.");

        
      bool addCrewMember = true;
      while(addCrewMember) {
        string crewInput = Console.ReadLine();
        if(crewInput != ""){
          //check if value exists also, confirm not already added
          try {
            if (crew.Contains(rolodex[int.Parse(crewInput) - 1])){
              Console.WriteLine($"{rolodex[int.Parse(crewInput) - 1].Name} is already a crew member. Choose another.");
              
            }else {
              try {
                Console.WriteLine("in the try");
                //check if enough percentage is available to hire this robber
                int runningPercentage = crew.Sum(member => member.PercentageCut);
                Console.WriteLine($"running percent {runningPercentage}");
                //if()
                crew.Add(rolodex[int.Parse(crewInput) - 1]);
                // Console.Clear();

                printCrew();
                printRolodex(rolodex);
              }
              catch{
                Console.WriteLine("invalid number, try another");
              }
            }
          }
          catch (System.ArgumentOutOfRangeException){
                Console.WriteLine("invalid number, try another");
          }
        }else{
          addCrewMember = false;
          printCrew();
        }
      } //end while addCrewMember

    }
 
  }
}
