using Newtonsoft.Json;
using System;

namespace PackageCalculator;

class Program
{
    static void Main(string[] args)
    {
        ShippingCalculator shippingCalculator = new ShippingCalculator();
        // reads from the json files and adds it to a list
        List<Item> items = shippingCalculator.ReadItemsFromJson("items.json");
        
        // Calculates shipping costs
        foreach (var item in items)
        {
           shippingCalculator.CalculateCosts(item);
        }
        
        // generates a list based on items and prints it out to a file
        shippingCalculator.GenerateShoppingList(items, "shopping_list.txt");
        
        Console.WriteLine("Shipping costs and shopping list generated successfully.");
    }
}