namespace BakedGoods.Models
{
  public class Pastry
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

    public static string SpecialDealString ()
    {
      if(SpecialPrice % Price == 0)
      {
        int quantityCharged = SpecialPrice/Price;
        int numberFree = SpecialQuantity - quantityCharged;
        return $"{quantityCharged} Pastries, get {numberFree} free";
      }
      else
      {
        return $"{SpecialQuantity} Pastries for ${SpecialPrice}";
      }
    }

    public int PastryTotal(int quantity)
    {
      int cost = 0;
      bool specialDeal = CheckSpecial(quantity);
      cost = CalculateCost(quantity, specialDeal);
      return cost;
    }

    private bool CheckSpecial(int quantity)
    {
      if (quantity % SpecialQuantity == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private int CalculateCost(int quantity, bool deal)
    {
      if (deal)
      {
        int dealsToCharge = quantity/SpecialQuantity;
        return dealsToCharge * SpecialPrice;
      }
      else
      {
        return quantity * Price;
      }
    }
  }
}