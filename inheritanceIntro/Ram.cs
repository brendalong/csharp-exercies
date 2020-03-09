using System;

namespace inheritanceIntro
{
  public class Ram : Vehicle
  { // Gas powered truck
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public int MaxOccupancy { get; set; }

    public void RefuelTank() { }
  }
}