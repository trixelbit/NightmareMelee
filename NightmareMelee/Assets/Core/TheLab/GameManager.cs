using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public static Player Player;

    public InventorySystem InventorySystem;

    public List<IPausable> PausableOjects;

    private void Awake()
    {
        Instance = this;
        InventorySystem =  new InventorySystem();
    }

    public void IncreaseHP(int increaseAmount)
    { 
    
    }
     
}
