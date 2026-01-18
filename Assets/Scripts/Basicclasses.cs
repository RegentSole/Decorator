using UnityEngine;

// ScriptableObject для данных хотдога
[CreateAssetMenu(fileName = "HotdogData", menuName = "Hotdogs/Hotdog Data")]
public class HotdogData : ScriptableObject
{
    public string hotdogName;
    public int baseCost;
    public int baseWeight;
}

// ScriptableObject для данных ингредиента
[CreateAssetMenu(fileName = "IngredientData", menuName = "Hotdogs/Ingredient Data")]
public class IngredientData : ScriptableObject
{
    public string ingredientName;
    public int additionalCost;
    public int additionalWeight;
}