namespace BakedGoods.Models
{
  public class Pastry : BakedItem
  {
    public static int Price { get; set; }
    public static int SpecialQuantity { get; set; }
    public static int SpecialPrice { get; set; }

    public Pastry()
    {
      Price = 2;
      SpecialQuantity = 3;
      SpecialPrice = 5;
    }

  }
}