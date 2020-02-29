namespace BakedGoods.Models
{
  public class Pastry : BakedItem
  {
    public Pastry() : base("Pastry")
    {
      Price = 2;
      SpecialQuantity = 3;
      SpecialPrice = 5;
    }
  }
}