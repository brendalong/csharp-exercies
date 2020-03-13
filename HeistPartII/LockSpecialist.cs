using System;

namespace HeistPartII {

    public class LockSpecialist : IRobber {
        public string Name {get; set;}

        public int SkillLevel {get; set;}

        public int PercentageCut {get; set;}

        public void PerformSkill(Bank bank){
            // Console.WriteLine("hacker perform skill");
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is picking the vault. Decreased vault score {SkillLevel} points");
            if(bank.VaultScore <= 0){
                Console.WriteLine($"{Name} has picked the lock");
            }
                                                                                                                                                                       
        }

        public override string ToString(){
            return $"LOCK SPECIALIST: {Name} - Skill: {SkillLevel} - Cut {PercentageCut}";
        }

    }
}