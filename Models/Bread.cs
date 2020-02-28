namespace BakedGoods.Models
{
  public class Bread : BakedItem
  {
    public static int Price { get; set; }
    public static int SpecialQuantity { get; set; }
    public static int SpecialPrice { get; set; }

    public Bread()
    {
      Price = 5;
      SpecialQuantity = 3;
      SpecialPrice = 2 * Price;
    }

  }
}