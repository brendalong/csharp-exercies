using System;

namespace ClassesIntro {
  class Program {
    static void Main (string[] args) {
      Console.WriteLine ("Hello World!");

      // Usage Example in a Program.cs file somewhere
      Car stella = new Car ();

      // UseEmergencyBreak method can use the protected SqueezeBreakPads from the Automobile class.
      Console.WriteLine ($"Applying the break from stella: {stella.UseEmergencyBreak()}");
    }
  }
}