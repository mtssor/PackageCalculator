namespace PackageCalculator;

public class PackingOptions
{
    public string CalculatePackingOption(Item item)
    {
        double totalDimension = item.Length + item.Width + item.Height;
        if (totalDimension <= 90 && item.Height <= 2 && item.Weight <= 3500)
        {
            if (item.Height <= 2)
            {
                if (totalDimension <= 27)
                    return "11x16cm";
                else if (totalDimension <= 36)
                    return "15x21cm";
                else if (totalDimension <= 52)
                    return "18x26cm";
                else if (totalDimension <= 99)
                    return "27x36cm";
                else
                    return "35x47cm";
            }
            else if (item.Height <= 12)
            {
                if (totalDimension <= 45)
                    return "Mini";
                else if (totalDimension <= 64)
                    return "Liten";
                else if (totalDimension <= 100)
                    return "Stor";
                else
                    return "Eske Norgespakke";
            }
        }
        return "Too Large to Ship";
    }
}
