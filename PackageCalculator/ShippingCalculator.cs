using Newtonsoft.Json;

namespace PackageCalculator;

public class ShippingCalculator
{
    public List<Item> ReadItemsFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Item>>(json);
    }

    public void CalculateCosts(Item item)
    {
        PackingOptions packingOptions = new PackingOptions();
        string packingOption = packingOptions.CalculatePackingOption(item);

        PostageOptions postageOptions = new PostageOptions();
        string postageOption = postageOptions.CalculatePostageOption(item);
        
        Console.WriteLine($"Item: {item.Name}, Packing: {packingOption}, Postage: {postageOption}");
    }

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