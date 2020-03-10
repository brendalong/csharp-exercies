using System;
using System.Collections.Generic;

namespace flowershop
{
  public class FlowerShop
  {
    public List<Rose> Roses = new List<Rose>();
    public List<Tulip> Tulips = new List<Tulip>();
    public List<Iris> Irises = new List<Iris>();
    public List<Daisy> Daisys = new List<Daisy>();


    public List<IMothersDay> MakeMothersDayArrangement()
    {
      List<IMothersDay> Arrangement = new List<IMothersDay>();
      Arrangement.Add(new Rose());
      Arrangement.Add(new Rose());
      Arrangement.Add(new Tulip());
      //following won't work since it doesn't play by rules.
      // Arrangement.Add(new Daisy());

      return Arrangement;
    }

    public List<IBirthday> MakeBirthdayArrangement()
    {
      List<IBirthday> Arrangement = new List<IBirthday>();
      Arrangement.Add(new Daisy());
      Arrangement.Add(new Rose());

      return Arrangement;
    }

    public List<IGetWell> MakeGetWellArrangement()
    {

      List<IGetWell> Arrangement = new List<IGetWell>();
      Arrangement.Add(new Violet());
      Arrangement.Add(new Iris());

      return Arrangement;
    }

  }
}