using Newtonsoft.Json;

namespace PackageCalculator;

public class ShippingCalculator
{
    // Reads from a Json file and turns it into a list of items
    public List<Item> ReadItemsFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Item>>(json);
    }

    // Calculates packaging and postage options for items
    public void CalculateCosts(Item item)
    {
        PackingOptions packingOptions = new PackingOptions();
        string packingOption = packingOptions.CalculatePackingOption(item);

        PostageOptions postageOptions = new PostageOptions();
        string postageOption = postageOptions.CalculatePostageOption(item);
        
        Console.WriteLine($"Item: {item.Name}, Packing: {packingOption}, Postage: {postageOption}");
    }

    // Generates shopping list based on the list of items and writes it to file
    public void GenerateShoppingList(List<Item> items, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Shopping list");
            foreach (var item in items)
            {
                writer.WriteLine($"Item: {item.Name}, Weight: {item.Weight} kg, " +
                                 $"Dimensions: {item.Length}x{item.Width}x{item.Height} cm");
            }
        }
    }
}