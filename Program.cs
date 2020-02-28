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
    Console.WriteLine("Bread: $" + bread.Price);
    Console.WriteLine("Pastry: $" + pastry.Price);
    Console.WriteLine("~~~~ Special Deals ~~~~");
    Console.WriteLine("Buy two Bread, get one free!");
    Console.WriteLine("Buy three Pastries for $5!");
  }

  static void TakeOrder()
  {
    Console.WriteLine("======= Your Order =======");
    Console.WriteLine("How many loaves of bread would you like?");
    string breadString = Console.ReadLine();
    int breadQuantity = CheckInput(breadString);
    Console.WriteLine("How many pastries would you like?");
    string pastryString = Console.ReadLine();
    int pastryQuantity = CheckInput(pastryString);
  }

  static int CheckInput(string input)
  {
    int number;
    bool isInt = Int32.TryParse(input, out number);
    if (isInt)
    {
      return number;
    }
    else
    {
      Console.WriteLine("Please enter a number.");
      return -1;
    }
  }
}