using System.Collections.Generic;
using UnityEngine;

public abstract class Hotdog
{
    protected string name;
    protected int baseCost;
    protected int baseWeight;

    protected Hotdog(string name, int baseCost, int baseWeight)
    {
        this.name = name;
        this.baseCost = baseCost;
        this.baseWeight = baseWeight;
    }

    public virtual string GetName() => name;
    public virtual int GetCost() => baseCost;
    public virtual int GetWeight() => baseWeight;
}