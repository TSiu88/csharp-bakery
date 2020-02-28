namespace BakedGoods.Models
{
  public class BakedItem
  {
    public BakedItem()
    {

    }

    public static string SpecialDealString ()
    {
      if(SpecialPrice % Price == 0)
      {
        int quantityCharged = SpecialPrice/Price;
        int numberFree = SpecialQuantity - quantityCharged;
        return $"{quantityCharged} Bread, get {numberFree} free";
      }
      else
      {
        return $"{SpecialQuantity} Bread for ${SpecialPrice}";
      }
    }

    public int GetTotal(int quantity)
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