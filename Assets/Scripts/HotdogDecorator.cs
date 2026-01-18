public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog decoratedHotdog;
    
    // Конструктор для декоратора
    protected HotdogDecorator(Hotdog hotdogToDecorate, IngredientData ingredient) 
        : base(hotdogToDecorate) // Используем конструктор копирования
    {
        decoratedHotdog = hotdogToDecorate;
        
        // Добавляем новый ингредиент
        if (ingredient != null)
        {
            AddIngredient(ingredient);
        }
    }
    
    public override string GetName()
    {
        // Используем базовое имя
        return base.GetName();
    }
}

public class PicklesDecorator : HotdogDecorator
{
    public PicklesDecorator(Hotdog hotdog, IngredientData picklesData) 
        : base(hotdog, picklesData)
    {
    }
    
    public override string GetName()
    {
        return $"{base.GetName()} с маринованными огурцами";
    }
}

public class SweetOnionDecorator : HotdogDecorator
{
    public SweetOnionDecorator(Hotdog hotdog, IngredientData onionData) 
        : base(hotdog, onionData)
    {
    }
    
    public override string GetName()
    {
        return $"{base.GetName()} со сладким луком";
    }
}