using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CustomScriptables/Items/HealthUp")]
public class HealthUp : Item
{
    public int IncreaseAmount;

    public override void ExecuteAffect()
    {
        GameManager.Instance.IncreaseHP(IncreaseAmount);
    }
}
