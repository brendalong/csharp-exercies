using System;

namespace HeistPartII {

    public class Hacker : IRobber {

        public string Name {get; set;}

        public int SkillLevel {get; set;}

        public int PercentageCut {get; set;}

        public void PerformSkill(Bank bank){
            // Console.WriteLine("hacker perform skill");
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased alarm by {SkillLevel} points");
            if(bank.AlarmScore <= 0){
                Console.WriteLine($"{Name} has disabled the bank alarm");
            }
                                                                                                                                                                       
        }

        public override string ToString(){
            return $"HACKER: {Name} - Skill: {SkillLevel} - Cut {PercentageCut}";
        }

    }
}