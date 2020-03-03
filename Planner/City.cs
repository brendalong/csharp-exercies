using System;
using System.Collections.Generic;

namespace Planner
{
  // Define class here
  public class City
  {

    private string _mayor;

    private int _yearEstablished;

    public string cityname { get; set; }
    public List<Building> allBuildings { get; set; }

    public City(string name)
    {
      cityname = name;
      _yearEstablished = DateTime.Now.Year;
      allBuildings = new List<Building>();
    }

    public void setYearEstablished(int year)
    {
      _yearEstablished = year;
    }

    public void setMayor(string name)
    {
      _mayor = name;
    }

    public void addNewBuilding(Building building)
    {
      allBuildings.Add(building);
    }

  }
}

//private
//public
//constructor
//methods
// Name of the city.
// The mayor of the city.
// Year the city was established.
// A collection of all of the buildings in the city.
// A method to add a building to the city.