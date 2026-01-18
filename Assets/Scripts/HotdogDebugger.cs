using UnityEngine;

public class HotdogDebugger : MonoBehaviour
{
    [Header("Hotdog Data Assets")]
    public HotdogData classicHotdogData;
    public HotdogData meatHotdogData;
    public HotdogData cheeseHotdogData;
    
    [Header("Ingredient Data Assets")]
    public IngredientData picklesData;
    public IngredientData sweetOnionData;
    
    void Start()
    {
        // Проверяем, что все необходимые объекты назначены
        if (!ValidateData())
        {
            return;
        }
        
        Debug.Log("=== ДЕБАГ ИНФОРМАЦИЯ О ХОТДОГАХ ===");
        
        // 1. Базовый классический хотдог
        Hotdog classic = new ClassicHotdog(classicHotdogData);
        Debug.Log($"Хот-дог {classic.GetName()} ({classic.GetWeight()}г) — {classic.GetCost()}р.");
        
        // 2. Классический хотдог с маринованными огурцами
        Hotdog classicWithPickles = new ClassicHotdog(classicHotdogData);
        classicWithPickles = new PicklesDecorator(classicWithPickles, picklesData);
        Debug.Log($"Хот-дог {classicWithPickles.GetName()} ({classicWithPickles.GetWeight()}г) — {classicWithPickles.GetCost()}р.");
        
        // 3. Классический хотдог со сладким луком
        Hotdog classicWithOnion = new ClassicHotdog(classicHotdogData);
        classicWithOnion = new SweetOnionDecorator(classicWithOnion, sweetOnionData);
        Debug.Log($"Хот-дог {classicWithOnion.GetName()} ({classicWithOnion.GetWeight()}г) — {classicWithOnion.GetCost()}р.");
        
        Debug.Log("\nДополнительная информация:");
        
        // 4. Мясной хотдог
        if (meatHotdogData != null)
        {
            Hotdog meat = new MeatHotdog(meatHotdogData);
            Debug.Log($"Хот-дог {meat.GetName()} ({meat.GetWeight()}г) — {meat.GetCost()}р.");
        }
        
        // 5. Сырный хотдог
        if (cheeseHotdogData != null)
        {
            Hotdog cheese = new CheeseHotdog(cheeseHotdogData);
            Debug.Log($"Хот-дог {cheese.GetName()} ({cheese.GetWeight()}г) — {cheese.GetCost()}р.");
        }
        
        // 6. Комбинированный: мясной хотдог с огурцами и луком
        if (meatHotdogData != null)
        {
            Hotdog meatCombo = new MeatHotdog(meatHotdogData);
            meatCombo = new PicklesDecorator(meatCombo, picklesData);
            meatCombo = new SweetOnionDecorator(meatCombo, sweetOnionData);
            Debug.Log($"Хот-дог {meatCombo.GetName()} ({meatCombo.GetWeight()}г) — {meatCombo.GetCost()}р.");
        }
    }
    
    private bool ValidateData()
    {
        bool isValid = true;
        
        if (classicHotdogData == null)
        {
            Debug.LogError("ClassicHotdogData is not assigned!");
            isValid = false;
        }
        
        if (picklesData == null)
        {
            Debug.LogError("PicklesData is not assigned!");
            isValid = false;
        }
        
        if (sweetOnionData == null)
        {
            Debug.LogError("SweetOnionData is not assigned!");
            isValid = false;
        }
        
        if (isValid)
        {
            Debug.Log("All data validated successfully!");
        }
        
        return isValid;
    }
}