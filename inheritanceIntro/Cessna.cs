using System;

namespace inheritanceIntro
{
  public class Cessna : Vehicle
  { // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public int MaxOccupancy { get; set; }

    public void RefuelTank() { }
  }
}