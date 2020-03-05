using System;

namespace ClassesIntroFromAdam
{
  //making a blueprint
  //don't have a car until we create an instance
  public class Car
  {
    //These are fields - no get or set
    //use the '_' with private
    private int _milesDriven;
    //define a property on type
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool NeedsMaintance { get; set; } = false;
    //must have get defined even within class
    public bool IsClean { get; set; } = false;

    //computed prop - readonly
    public string Description
    {
      get
      {
        return $"{ Year} { Make}{ Model}";
      }
    }

    // private string Mileage {} //checkout the error msg

    public void Drive(int miles)
    {
      _milesDriven += miles;
      if (_milesDriven > 10000)
      {
        NeedsMaintance = true;
      }
    }

    public void Service()
    {
      NeedsMaintance = false;
    }

    //method overloading - able to define multiple ways of invoking
    //with different types of arguments
    public void Service(bool addCleaningService)
    {
      NeedsMaintance = false;
      IsClean = addCleaningService;
    }

    // constructor method
    // named same as class
    // no return type defined
    public Car()
    {
      Console.WriteLine("Inside the car constructor");
    }
  }
}