using System;

namespace inheritanceIntro
{
  public class Vehicle
  {
    public string MainColor { get; set; }

    public int MaxOccupancy { get; set; }

    //**virtual** gives permission to child to override
    public virtual void Drive()
    {
      Console.WriteLine("Vrooom!");
    }

  }

}