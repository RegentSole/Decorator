using UnityEngine;

[CreateAssetMenu(fileName = "HotdogData", menuName = "Hotdogs/Hotdog Data")]
public class HotdogDataSO : ScriptableObject
{
    public string hotdogName;
    public int baseCost;
    public int baseWeight;
}