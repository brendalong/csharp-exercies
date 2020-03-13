using System;

namespace HeistPartII {

    public class Muscle : IRobber {

        public string Name {get; set;}
        public int SkillLevel {get; set;}

        public int PercentageCut {get; set;}

        public void PerformSkill(Bank bank){
            // Console.WriteLine("hacker perform skill");
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is engaging the security guards. Decreased guard score {SkillLevel} points");
            if(bank.SecurityGuardScore <= 0){
                Console.WriteLine($"{Name} has defeated the security guards");
            }
                                                                                                                                                                       
        }

        public override string ToString(){
            return $"MUSCLE: {Name} - Skill: {SkillLevel} - Cut {PercentageCut}";
        }


    }
}