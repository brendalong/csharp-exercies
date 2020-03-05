using System;

namespace ClassesIntroFromAdam
{
  class Program
  {
    static void Main(string[] args)
    {

      // Dictionary<string, string> car = new Dictionary<string, string>();
      // car.Add("Make", "Ford");
      // car.Add("Model", "Bronco");
      // car.Ad("Year", "1992"); //yuck - different type

      Car myJeep = new Car();
      myJeep.Make = "Jeep";
      myJeep.Model = "Wrangler";
      myJeep.Year = 2014;

      Car mySub = new Car()
      {
        Make = "jfj",
        Model = "jjjj",
        Year = 1998
      };

      Console.WriteLine(myJeep.Description);

      mySub.Drive(9999);
      Console.WriteLine($"Bronco needs service {mySub.NeedsMaintance}");
      mySub.Drive(60);
      Console.WriteLine($"Bronco needs service {mySub.NeedsMaintance}");

      mySub.Service(true);
      //or
      mySub.Service();

    }
  }
}
