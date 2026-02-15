using UnityEngine;

[CreateAssetMenu(fileName = "IngredientData", menuName = "Hotdogs/Ingredient Data")]
public class IngredientDataSO : ScriptableObject
{
    public string ingredientName;
    public int additionalCost;
    public int additionalWeight;
}