using Newtonsoft.Json;
using System;

namespace PackageCalculator;

class Program
{
    static void Main(string[] args)
    {
        ShippingCalculator shippingCalculator = new ShippingCalculator();
        List<Item> items = shippingCalculator.ReadItemsFromJson("items.json");

        foreach (var item in items)
        {
           shippingCalculator.CalculateCosts(item);
        }
        
        shippingCalculator.GenerateShoppingList(items, "shopping_list.txt");
        
        Console.WriteLine("Shipping costs and shopping list generated successfully.");
    }
}