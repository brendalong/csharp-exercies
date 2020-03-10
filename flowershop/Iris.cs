using System;

namespace flowershop
{

  public class Iris : IBirthday
  {
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Cost { get; set; }
    public string WaterSchedule { get; set; }
    public bool IsThorny { get; set; } = false;
    public string Frangrance { get; set; }

    public bool isLiving { get; set; } = false;

    public override string ToString()
    {
      return $"A fancy {Color} iris named {Name} {IsThorny}";
    }
  }

}