using System;

namespace inheritanceIntro
{
  public class Tesla : Vehicle
  { // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
      Console.WriteLine("Rumble Rumble");
    }

    public override string ToString()
    {
      return "this is my tesla";
    }
  }
}