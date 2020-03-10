using System;

namespace flowershop
{

  public class Rose : IMothersDay, IBirthday
  {
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Cost { get; set; }
    public string WaterSchedule { get; set; }
    public bool IsThorny { get; set; } = false;
    public double StemLength { get; set; }

    public string Frangrance { get; set; }

    public override string ToString()
    {
      return $"A fancy {Color} rose named {Name} {IsThorny}";
    }


  }
}