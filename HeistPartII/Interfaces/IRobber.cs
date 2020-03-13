using System;

namespace HeistPartII {

    public interface IRobber
    {
        string Name {get; set;}
        int SkillLevel {get; set;}

        int PercentageCut {get; set;}

        // void PerformSkill (Bank){
        //     Console.WriteLine("PerformSkill on this bank");
        // }

        void PerformSkill(Bank bank){
            //no return yet
        }
        
    }
}
// A string property for Name
// An integer property for SkillLevel
// An integer property for PercentageCut
// A method called PerformSkill that takes in a Bank parameter and doesn't return anything.