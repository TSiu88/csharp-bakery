namespace BakedGoods.Models
{
  public class BakedItem
  {
    public string Item { get; set;}
    public int Price { get; set; }
    public int SpecialQuantity { get; set; }
    public int SpecialPrice { get; set; }
    public BakedItem(string item)
    {
      Item = item;
      Price = 1;
      SpecialQuantity = 1;
      SpecialPrice = 1;
    }

    public virtual string SpecialDealString ()
    {
      if(SpecialPrice % Price == 0)
      {
        int quantityCharged = SpecialPrice/Price;
        int numberFree = SpecialQuantity - quantityCharged;
        return $"{quantityCharged} {Item}, get {numberFree} free";
      }
      else
      {
        return $"{SpecialQuantity} {Item} for ${SpecialPrice}";
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