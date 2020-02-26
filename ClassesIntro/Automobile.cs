using System;

// Base class
public class Automobile {

  public string Break () {
    Console.WriteLine ("calling just Break");
    SqueezeBreakPads ();
    return "skuuuuuur";
  }

  protected string SqueezeBreakPads () {
    Console.WriteLine ("calling squeeze breaks");
    return "aaa";
  }
}