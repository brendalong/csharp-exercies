using System;

namespace HeistPartII
{
  public class Bank
  {
    //integer property for CashOnHand
    public int CashOnHand { get; set; } = 0;
    //integer property for AlarmScore
    public int AlarmScore { get; set; } = 0;
    //integer property for VaultScore
    public int VaultScore { get; set; } = 0;
    //integer property for SecurityGuardScore
    public int SecurityGuardScore { get; set; } = 0;
    

    public bool IsSecure
    {
      //A computed boolean property called IsSecure.
    //If all the scores are less than or equal to 0,
    //this should be false. If any of the scores are above 0,
    //this should be true
      get
      {
        if (CashOnHand > 0 && AlarmScore > 0 && VaultScore > 0 && SecurityGuardScore > 0)
        {
          return false;
        }
        else
        {
          return true;
        }
      }
    }



   public Bank(){
    //randomly assign values for these properties:
    // AlarmScore (between 0 and 100)
    // VaultScore (between 0 and 100)
    // SecurityGuardScore (between 0 and 100)
    // CashOnHand (between 50,000 and 1 million)
    Random random = new Random();
    AlarmScore = random.Next(1, 100);
    VaultScore = random.Next(0, 100);
    SecurityGuardScore = random.Next(0, 100);
    CashOnHand = random.Next(50000, 1000000);


   }

  }
}