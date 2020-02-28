using System;
using BakedGoods.Models;

namespace BakedGoods
{
  class Program
  {
    public static Bread bread;
    public static Pastry pastry;

    static void Main()
    {
      bread = new Bread();
      pastry = new Pastry();
      Console.WriteLine(".-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-.");
      Console.WriteLine(")|\t Welcome to Pierre's Bakery! \t|(");
      Console.WriteLine("'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-'");
      DisplayMenu();
      TakeOrder();
    }

    static void DisplayMenu()
    {
      Console.WriteLine("   ~~~~~~~~~~ Today's Menu ~~~~~~~~~~");
      Console.WriteLine("\tBread: $" + Bread.Price);
      Console.WriteLine("\tPastry: $" + Pastry.Price);
      Console.WriteLine("   ~~~~~~~~~ Special Deals ~~~~~~~~~~");
      Console.WriteLine($"\tBuy {Bread.SpecialDealString()}!");
      Console.WriteLine($"\tBuy {Pastry.SpecialDealString()}!");
    }

    static void TakeOrder()
    {
      Console.WriteLine("============== Your Order ==============");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadString = Console.ReadLine();
      int breadQuantity = CheckInput(breadString);
      Console.WriteLine("How many pastries would you like?");
      string pastryString = Console.ReadLine();
      int pastryQuantity = CheckInput(pastryString);
      Console.WriteLine("========================================");
      CalculateTotal(breadQuantity, pastryQuantity);
    }

    static int CheckInput(string input)
    {
      int number;
      bool isInt = Int32.TryParse(input, out number);
      if (isInt && number > 0)
      {
        return number;
      }
      else if (input.ToLower() == "quit")
      {
        Console.WriteLine("Thank you for shopping at Pierre's Bakery! Goodbye!");
        Environment.Exit(0);
        return -1;
      }
      else
      {
        Console.WriteLine("No valid number entered.  Assumed to order 0.");
        return 0;
      }
    }

    static void CalculateTotal(int breadQuanitity, int pastryQuantity)
    {
      int breadTotal = bread.GetTotal(breadQuanitity);
      int pastryTotal = pastry.GetTotal(pastryQuantity);
      int totalCost = breadTotal + pastryTotal;
      PrintTotal(breadTotal, pastryTotal, totalCost);
    }

    static void PrintTotal(int breadTotal, int pastryTotal, int totalCost)
    {
      Console.WriteLine("-._.-=-._.-=-. Order Total .-=-._.-=-._.-");
      Console.WriteLine($"\tBread Total: ${breadTotal}");
      Console.WriteLine($"\tPastry Total: ${pastryTotal}");
      Console.WriteLine($"\tTotal Cost: ${totalCost}");
      Console.WriteLine("-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-");
    }
  }
}