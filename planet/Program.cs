using System;
using System.Collections.Generic;

namespace NSSOrientation
{
  public class Program
  {
    public static void Main()
    {

      List<string> planetList = new List<string>(){
            "Mercury", "Mars"
          };


      //Add() Jupiter and Saturn end of the list.
      planetList.Add("Jupiter");
      planetList.Add("Saturn");
      //New List contains that last two planet of our solar system.
      List<string> planetList2 = new List<string>() { "Pluto", "Venus" };


      //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
      Console.WriteLine("---planetlist---");
      planetList.ForEach(planet => Console.WriteLine(planet));

      Console.WriteLine("---planetlist2---");
      planetList2.ForEach(planet => Console.WriteLine(planet));

      //Combine the two lists by using AddRange().
      planetList.AddRange(planetList2);
      Console.WriteLine("---new planetlist---");
      planetList.ForEach(planet => Console.WriteLine(planet));

      //Use Insert() to add Earth, and Venus in the correct order.
      planetList.Insert(5, "Pluto2");
      planetList.Insert(3, "Earth");
      Console.WriteLine("---add pluto2 and Earth---");
      planetList.ForEach(planet => Console.WriteLine(planet));


      // Use Add() again to add Pluto to the end of the list.
      planetList.Add("Final Pluto");
      Console.WriteLine("---final pluto---");
      planetList.ForEach(planet => Console.WriteLine(planet));

      //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.

      List<string> rockyPlanets = new List<string>
      (planetList.GetRange(2, 3).ToArray());

      // string[] output = planetList.GetRange(2, 3).ToArray();

      Console.WriteLine("---rocky planets---");
      foreach (string planet in rockyPlanets)
      {
        Console.WriteLine(planet);
      }



    }
  }
}