using System;

namespace flowershop
{

  public class Daisy : IBirthday
  {
    public string Color { get; set; }

    public string Name { get; set; }
    public string Type { get; set; }
    public string Cost { get; set; }
    public string WaterSchedule { get; set; }
    public bool IsThorny { get; set; } = false;

    public string Frangrance { get; set; }

    public override string ToString()
    {
      return $"A bright {Color} daisy named {Name} {IsThorny}";
    }

  }

}