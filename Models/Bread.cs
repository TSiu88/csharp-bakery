namespace BakedGoods.Models
{
  public class Bread : BakedItem
  {
    public Bread() : base("Bread")
    {
      Price = 5;
      SpecialQuantity = 3;
      SpecialPrice = 2 * Price;
    }

  }
}