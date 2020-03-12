using System;

namespace DiggersAndFliers
{
  public class RattleSnake : ISlithering, IDigging
  {
    public bool isCarnivore { get; } = true;

    public void Dig()
    {
      Console.WriteLine("Snakes burrow or dig in the ground");
    }
    public void Slither()
    {
      Console.WriteLine("Animal is a slithering");
    }
  }
}