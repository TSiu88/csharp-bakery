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
    Console.WriteLine("How many pastries would you like?");
  }
}