namespace PackageCalculator;

public class PostageOptions
{
    // stores postage options based on weight
    private static readonly Dictionary<int, string> postageOptions = new Dictionary<int, string>()
    {
        { 20, "23 kr" }, { 50, "29 kr" }, { 100, "36 kr" }, { 350, "55 kr" },
        { 1000, "90 kr" }, { 5000, "73 kr" }, { 10000, "135 kr" }
    };
    // calculates the postage based on weight
    public string CalculatePostageOption(Item item)
    {
        if (item.Weight > 5000 || item.Height > 12)
            return "Too big to ship";
        // iterates through the postage options sorted by descending weight
        foreach (var option in postageOptions.OrderByDescending(opt => opt.Key))
        {
            if (item.Weight <= option.Key)
                return option.Value;
        }

        return "Too big to ship";
    }
}

