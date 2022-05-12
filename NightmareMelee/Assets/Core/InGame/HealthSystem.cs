using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : IHealthSystem
{
    public int HealthCount { get; private set; }

    public int MaxHealthCount;

    public event Action<int> HealthChanged;

    public void IncreaseMaxHealth(int increaseAmount)
    {
        if (HealthCount == MaxHealthCount)
        {
            HealthCount += increaseAmount;
            HealthChanged.Invoke(HealthCount);
        }
        MaxHealthCount += increaseAmount;
    }

    public void IncreaseHealth(int increaseAmount)
    {
        HealthCount += increaseAmount;
        HealthCount = HealthCount > MaxHealthCount?  MaxHealthCount : HealthCount;
        HealthChanged.Invoke(HealthCount);
    }

    public void DecreaseHealth(int decreaseAmount)
    { 
        HealthCount -= decreaseAmount;
        HealthChanged.Invoke(HealthCount);
    }
}

public interface IHealthSystem
{
    public void IncreaseMaxHealth(int increaseAmount);

    public void IncreaseHealth(int increaseAmount);

    public void DecreaseHealth(int decreaseAmount);
}
