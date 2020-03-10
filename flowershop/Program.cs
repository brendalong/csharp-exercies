using System;

namespace flowershop
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Rose stella = new Rose();
      stella.Name = "Stella";
      Console.WriteLine(stella.ToString());

      Daisy del = new Daisy();
      del.Name = "Del";
      Console.WriteLine(del.ToString());

      Tulip tutu = new Tulip();
      tutu.Name = "Tutu";
      Console.WriteLine(tutu.ToString());

      Iris darby = new Iris();
      darby.Name = "Darby";
      Console.WriteLine(darby.ToString());
    }
  }
}
