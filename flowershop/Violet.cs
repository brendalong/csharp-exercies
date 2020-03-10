using System;

namespace flowershop
{
  public class Violet : IGetWell, IBirthday
  {

    public string Color { get; set; }
    public bool isLiving { get; set; } = true;

    public double StemLength { get; set; }

  }
}