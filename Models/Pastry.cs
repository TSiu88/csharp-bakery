using System;

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
      return cost;
    }
  }
}