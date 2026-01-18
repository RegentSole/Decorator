using System.Collections.Generic;
using UnityEngine;

public abstract class Hotdog
{
    protected string name;
    protected HotdogData data;
    protected List<IngredientData> additionalIngredients = new List<IngredientData>();
    
    protected Hotdog(HotdogData hotdogData)
    {
        if (hotdogData == null)
        {
            Debug.LogError("HotdogData is null!");
            return;
        }
        
        data = hotdogData;
        name = data.hotdogName;
    }
    
    // Метод для клонирования данных (для декораторов)
    protected Hotdog(Hotdog otherHotdog)
    {
        if (otherHotdog != null)
        {
            this.data = otherHotdog.data;
            this.name = otherHotdog.name;
            this.additionalIngredients = new List<IngredientData>(otherHotdog.additionalIngredients);
        }
    }
    
    public virtual string GetName()
    {
        return name;
    }
    
    public virtual int GetCost()
    {
        int totalCost = data != null ? data.baseCost : 0;
        foreach (var ingredient in additionalIngredients)
        {
            totalCost += ingredient.additionalCost;
        }
        return totalCost;
    }
    
    public virtual int GetWeight()
    {
        int totalWeight = data != null ? data.baseWeight : 0;
        foreach (var ingredient in additionalIngredients)
        {
            totalWeight += ingredient.additionalWeight;
        }
        return totalWeight;
    }
    
    public void AddIngredient(IngredientData ingredient)
    {
        if (ingredient != null)
            additionalIngredients.Add(ingredient);
    }
}

// Классы-наследники
public class ClassicHotdog : Hotdog
{
    public ClassicHotdog(HotdogData data) : base(data)
    {
    }
}

public class MeatHotdog : Hotdog
{
    public MeatHotdog(HotdogData data) : base(data)
    {
    }
}

public class CheeseHotdog : Hotdog
{
    public CheeseHotdog(HotdogData data) : base(data)
    {
    }
}