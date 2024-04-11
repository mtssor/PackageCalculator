namespace PackageCalculator;

public abstract class PostageOption
{
    public string Name { get; protected set; }
    public int MaxWeight { get; protected set; }

    public abstract bool IsSuitable(Item item);
    public abstract double CalculateCost(Item item);
}