namespace PackageCalculator;
// This class handles the calculation of packing options based on item dimensions.
public class PackingOptions2
{
    // Array containing the available packing options.
    private static readonly string[] packingOptions =
    {
        "11x16cm", "15x21cm", "18x26cm", "27x36cm", "35x47cm",
        "Mini", "Liten", "Stor", "Eske Norgespakke"
    };
    
    // Method to calculate the appropriate packing option for the given item.
    public string CalculatePackingOption(Item item)
    {
        // Calculate the total dimensions of the item.
        double totalDimension = item.Length + item.Width + item.Height;
        
        // Check if the item is too large or heavy to be shipped.
        if (totalDimension > 90 || item.Weight > 3500)
            return "too large to ship";
        
        // Calculate the index of the appropriate packing option based on item dimensions.
        int optionIndex = item.Height <= 2 ? (int)(totalDimension / 9 - 1) : (int)(totalDimension / 20 - 3);
        // Return the selected packing option.
        return packingOptions[optionIndex];
    }
}