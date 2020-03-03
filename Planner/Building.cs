using System;

namespace Planner
{
  // Define class here
  public class Building
  {
    public Building(string address)
    {
      _address = address;
      _dateConstructed = DateTime.Now;
    }

    // public void Construct()
    // {

    // }

    public void Purchase(string owner)
    {
      _owner = owner;
    }

    // private types
    private string _designer;
    private DateTime _dateConstructed;

    private string _address;
    private string _owner;

    // Stories typed as an integer.
    // Width typed as a double.
    // Depth typed as a double.
    // Volume should be read-only and should return width* depth * (3 * # of stories). Each story is 3 meters high.

    public int stories { get; set; }
    public double width { get; set; }
    public double depth { get; set; }

    // Calculated property that has no setter. It is readonly.
    public double getVolume
    {
      get
      {
        return width * depth;
      }
    }

    public void setDesigner(string name)
    {
      _designer = name;
    }

    public void showDetails()
    {
      Console.WriteLine($"Address: {_address}");
      Console.WriteLine($"Designed by: {_designer}");
      Console.WriteLine($"Constructed on: {_dateConstructed}");
      Console.WriteLine($"Owned by: {_owner}");
      Console.WriteLine($"{getVolume} square feet");


    }

  }

}