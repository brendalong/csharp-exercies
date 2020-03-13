using System;
using System.Collections.Generic;

namespace HeistPartII
{
  //https://gist.github.com/AdamSheaffer/c7563b750ab767f2123fd868e022dc67
  class Program
  {
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

      // Bank GreenBank = new Bank();

      Console.WriteLine($"There are currently {rolodex.Count} robbers in the rolodex");

      bool addAnother = true;

      while(addAnother){
        
        Console.Write("Add a new robber. Name > ");
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
    }
  }
}
