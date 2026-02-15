public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog hotdog;

    protected HotdogDecorator(Hotdog hotdog, string ingredientName, int additionalCost, int additionalWeight) 
        : base(ingredientName, additionalCost, additionalWeight) // эти параметры не используются напрямую
    {
        this.hotdog = hotdog;
    }
}