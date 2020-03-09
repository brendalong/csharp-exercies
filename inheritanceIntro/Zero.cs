using System;

namespace inheritanceIntro
{
  public class Zero : Vehicle
  {
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public int MaxOccupancy { get; set; }

    public void ChargeBattery() { }
  }

}