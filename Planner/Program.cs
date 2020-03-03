using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello City of CSharp");
      Console.WriteLine("--------------------");
      //make list to hold all the buildings
      List<Building> buildingList = new List<Building>();

      //make some buildings and add to list
      Building Brick = new Building("301 Park Place");
      // Brick.Construct();
      Brick.Purchase("Brenda");
      Brick.setDesigner("Sarah");
      Brick.stories = 2;
      Brick.width = 2;
      Brick.depth = 2;
      // Console.WriteLine($"Brick is {Brick}");


      Building Brick2 = new Building("2483 Broadway");
      // Brick2.Construct();
      Brick2.Purchase("Adam");
      Brick2.setDesigner("Bob");
      Brick2.stories = 4;
      Brick2.width = 1;
      Brick2.depth = 4;

      buildingList.Add(Brick);
      buildingList.Add(Brick2);

      foreach (var item in buildingList)
      {
        // item.Construct();
        Console.WriteLine("----------Building---------");
        item.showDetails();

      }

      City Sharpville = new City("Sharpville");
      Sharpville.addNewBuilding(Brick);
      Sharpville.addNewBuilding(Brick2);
      Sharpville.setMayor("Billy Script");
      Console.WriteLine($"new city {Sharpville}");

      Console.WriteLine($"-------{Sharpville.cityname}----------");
      foreach (Building building in Sharpville.allBuildings)
      {
        Console.WriteLine($"-------Building----------");
        building.showDetails();
      }




    }
  }
}
