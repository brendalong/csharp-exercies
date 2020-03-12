using System;

namespace DiggersAndFliers
{
  public class Rodent : IWalking, IDigging
  {
    public bool isCarnivore { get; } = false;

    public void Dig()
    {
      Console.WriteLine("Snakes burrow or dig in the ground");
    }
    public void Slither()
    {
      Console.WriteLine("OOPS a rodent does not slither");
    }
    public void Walk()
    {
      Console.WriteLine("rodent is walking");
    }
    public void Run()
    {
      Console.WriteLine("rodent is running");
    }
  }
}