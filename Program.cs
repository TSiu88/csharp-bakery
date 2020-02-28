using System;
using System.Collections.Generic;
using BakedGoods.Models;

class Program
{
  public static Bread bread;
  public static Pastry pastry;

  static void Main()
  {
    bread = new Bread();
    pastry = new Pastry();
    Console.WriteLine(".-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-.");
    Console.WriteLine(")| Welcome to Pierre's Bakery |(");
    Console.WriteLine("'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-'");
    DisplayMenu();
    TakeOrder();
  }

  static void DisplayMenu()
  {
    Console.WriteLine("~~~~~~~ Today's Menu ~~~~~~~");
    Console.WriteLine("Bread: $" + Bread.Price);
    Console.WriteLine("Pastry: $" + Pastry.Price);
    Console.WriteLine("~~~~~~ Special Deals ~~~~~~~");
    Console.WriteLine($"Buy {Bread.SpecialDealString()}!");
    Console.WriteLine($"Buy {Pastry.SpecialDealString()}!");
  }

  static void TakeOrder()
  {
    Console.WriteLine("======== Your Order ========");
    Console.WriteLine("How many loaves of bread would you like?");
    string breadString = Console.ReadLine();
    int breadQuantity = CheckInput(breadString);
    Console.WriteLine("How many pastries would you like?");
    string pastryString = Console.ReadLine();
    int pastryQuantity = CheckInput(pastryString);
    CalculateTotal(breadQuantity, pastryQuantity);
  }

  static int CheckInput(string input)
  {
    int number;
    bool isInt = Int32.TryParse(input, out number);
    if (isInt)
    {
      return number;
    }
    else if (input.ToLower() == "quit")
    {
      Environment.Exit(0);
      return -1;
    }
    else
    {
      Console.WriteLine("No number entered.  Assumed to order 0.");
      return 0;
    }
  }

  static void CalculateTotal(int breadQuanitity, int pastryQuantity)
  {
    int breadTotal = bread.BreadTotal(breadQuanitity);
    int pastryTotal = pastry.PastryTotal(pastryQuantity);
    int totalCost = breadTotal + pastryTotal;
    PrintTotal(breadTotal, pastryTotal, totalCost);
  }

  static void PrintTotal(int breadTotal, int pastryTotal, int totalCost)
  {
    Console.WriteLine(".-=-._.-=-. Order Total .-=-._.-=-.");
    Console.WriteLine($"Bread Total: ${breadTotal}");
    Console.WriteLine($"Pastry Total: ${pastryTotal}");
    Console.WriteLine($"Total Cost: ${totalCost}");
    Console.WriteLine(".-=-._.-=-._.-=-._.-=-._.-=-._.-=-.");
  }
}