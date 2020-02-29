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
      Price = 0;
      SpecialQuantity = 0;
      SpecialPrice = 0;
    }

    public string SpecialDealString ()
    {
      if (SpecialPrice <= 0 || SpecialQuantity <= 0)
      {
        if (SpecialQuantity > 0)
        {
          return $"Get {SpecialQuantity} {Item} for free today!";
        }
        else
        {
          return $"No special available for {Item} today!";
        }
        
      }
      else if (Price <= 0)
      {
        return $"All {Item} are free today!";
      }
      else if(SpecialPrice % Price == 0)
      {
        int quantityCharged = SpecialPrice/Price;
        int numberFree = SpecialQuantity - quantityCharged;
        return $"Buy {quantityCharged} {Item}, get {numberFree} free!";
      }
      else
      {
        return $"Buy {SpecialQuantity} {Item} for ${SpecialPrice}!";
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
      if (SpecialQuantity >0 && SpecialPrice <=0)
      {
        return true;
      }
      else if(SpecialQuantity <=0 || SpecialPrice <=0 || Price <=0)
      {
        return false;
      }
      else if (quantity % SpecialQuantity == 0)
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
        if (SpecialPrice <=0)
        {
          int numberToCharge = quantity-SpecialQuantity;
          if (numberToCharge <=0)
          {
            return 0;
          }
          else
          {
            return numberToCharge * Price;
          }
        }
        int dealsToCharge = quantity/SpecialQuantity;
        return dealsToCharge * SpecialPrice;
      }
      else
      {
        int cost = quantity * Price;
        if (cost < 0)
        {
          return 0;
        }
        else
        {
          return cost;
        }
      }
    }
  }
}