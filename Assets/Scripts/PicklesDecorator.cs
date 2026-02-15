public class PicklesDecorator : HotdogDecorator
{
    private string ingredientName;
    private int additionalCost;
    private int additionalWeight;

    public PicklesDecorator(Hotdog hotdog, string ingredientName, int additionalCost, int additionalWeight) 
        : base(hotdog, ingredientName, additionalCost, additionalWeight)
    {
        this.ingredientName = ingredientName;
        this.additionalCost = additionalCost;
        this.additionalWeight = additionalWeight;
    }

    public override string GetName() => $"{hotdog.GetName()} с {ingredientName}";
    public override int GetCost() => hotdog.GetCost() + additionalCost;
    public override int GetWeight() => hotdog.GetWeight() + additionalWeight;
}