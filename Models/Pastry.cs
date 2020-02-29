namespace BakedGoods.Models
{
  public class Pastry : BakedItem
  {
    public Pastry() : base("Pastries")
    {
      Price = 2;
      SpecialQuantity = 3;
      SpecialPrice = 5;
    }
  }
}