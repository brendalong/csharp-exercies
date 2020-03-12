using System;

namespace HeistPartII
{
  class Bank
  {
    //integer property for CashOnHand
    public int CashOnHand { get; set; } = 0;
    //integer property for AlarmScore
    public int AlarmScore { get; set; } = 0;
    //integer property for VaultScore
    public int VaultScore { get; set; } = 0;
    //integer property for SecurityGuardScore
    public int SecurityGuardScore { get; set; } = 0;
    //A computed boolean property called IsSecure.
    //If all the scores are less than or equal to 0,
    //this should be false. If any of the scores are above 0,
    //this should be true

    public bool IsSecure
    {
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



    // Bank()
    // {

    // }

  }
}