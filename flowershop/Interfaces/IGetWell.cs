namespace flowershop
{
  public interface IGetWell : IBirthday, IMothersDay
  {
    bool isLiving { get; set; }
  }

}