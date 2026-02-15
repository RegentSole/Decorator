using UnityEngine;

public class HotdogDebugger : MonoBehaviour
{
    [Header("Базовые хотдоги")]
    public HotdogDataSO classicData;
    public HotdogDataSO meatData;
    public HotdogDataSO cheeseData;

    [Header("Ингредиенты")]
    public IngredientDataSO picklesData;
    public IngredientDataSO sweetOnionData;

    void Start()
    {
        if (!ValidateData()) return;

        Debug.Log("=== ДЕБАГ ИНФОРМАЦИЯ О ХОТДОГАХ ===");

        // Базовый классический
        Hotdog classic = new ClassicHotdog(classicData.hotdogName, classicData.baseCost, classicData.baseWeight);
        Debug.Log($"{classic.GetName()} ({classic.GetWeight()}г) — {classic.GetCost()}р.");

        // Классический с огурцами
        Hotdog withPickles = new PicklesDecorator(
            new ClassicHotdog(classicData.hotdogName, classicData.baseCost, classicData.baseWeight),
            picklesData.ingredientName,
            picklesData.additionalCost,
            picklesData.additionalWeight
        );
        Debug.Log($"{withPickles.GetName()} ({withPickles.GetWeight()}г) — {withPickles.GetCost()}р.");

        // Классический с луком
        Hotdog withOnion = new SweetOnionDecorator(
            new ClassicHotdog(classicData.hotdogName, classicData.baseCost, classicData.baseWeight),
            sweetOnionData.ingredientName,
            sweetOnionData.additionalCost,
            sweetOnionData.additionalWeight
        );
        Debug.Log($"{withOnion.GetName()} ({withOnion.GetWeight()}г) — {withOnion.GetCost()}р.");

        Debug.Log("Дополнительная информация:");

        // Мясной
        Hotdog meat = new MeatHotdog(meatData.hotdogName, meatData.baseCost, meatData.baseWeight);
        Debug.Log($"{meat.GetName()} ({meat.GetWeight()}г) — {meat.GetCost()}р.");

        // Сырный
        Hotdog cheese = new CheeseHotdog(cheeseData.hotdogName, cheeseData.baseCost, cheeseData.baseWeight);
        Debug.Log($"{cheese.GetName()} ({cheese.GetWeight()}г) — {cheese.GetCost()}р.");

        // Мясной с двумя ингредиентами
        Hotdog meatCombo = new MeatHotdog(meatData.hotdogName, meatData.baseCost, meatData.baseWeight);
        meatCombo = new PicklesDecorator(meatCombo, picklesData.ingredientName, picklesData.additionalCost, picklesData.additionalWeight);
        meatCombo = new SweetOnionDecorator(meatCombo, sweetOnionData.ingredientName, sweetOnionData.additionalCost, sweetOnionData.additionalWeight);
        Debug.Log($"{meatCombo.GetName()} ({meatCombo.GetWeight()}г) — {meatCombo.GetCost()}р.");
    }

    private bool ValidateData()
    {
        if (classicData == null || meatData == null || cheeseData == null)
        {
            Debug.LogError("Не все данные хотдогов назначены!");
            return false;
        }
        if (picklesData == null || sweetOnionData == null)
        {
            Debug.LogError("Не все данные ингредиентов назначены!");
            return false;
        }
        return true;
    }
}