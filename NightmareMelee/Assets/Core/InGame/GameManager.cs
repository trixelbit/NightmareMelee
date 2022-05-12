using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public static Player Player;

    public static IInventorySystem InventorySystem;
    public static IHealthSystem HealthSystem;
    public static PauseSystem PauseSystem;
    
    private InventorySystem _inventorySystem;
    private HealthSystem _healthSystem;

    private void Awake()
    {
        Instance = this;
        _inventorySystem = new InventorySystem();
        _healthSystem = new HealthSystem();
        PauseSystem = new PauseSystem();
        
        InventorySystem = _inventorySystem as IInventorySystem;
        HealthSystem = _healthSystem as IHealthSystem;
    }
}
