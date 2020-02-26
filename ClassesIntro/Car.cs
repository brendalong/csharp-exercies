using System;

// Derived class
public class Car : Automobile {

  public string UseEmergencyBreak () {
    Console.WriteLine ("Use Emergency Breaks");
    SqueezeBreakPads ();
    return "skreeech!";
  }
}