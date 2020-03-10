using System;

namespace inheritanceIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      var myBike = new Zero();

      //get and set available from Vehicle
      myBike.MainColor = "Purple";
      myBike.MaxOccupancy = 2;

      var myTesla = new Tesla();
      myTesla.MainColor = "Midnight Silver";
      myTesla.MaxOccupancy = 6;

      var myRam = new Ram();
      myRam.MainColor = "Red";
      myRam.MaxOccupancy = 5;

      var myCessna = new Cessna();
      myCessna.MainColor = "White";
      myCessna.MaxOccupancy = 4;

      myBike.Drive();
      myTesla.Drive();
      myCessna.Drive();
      myCessna.Drive();

      //testing overright of the ToString from dotnet default base class object
      Console.WriteLine(myTesla);

    }
  }
}