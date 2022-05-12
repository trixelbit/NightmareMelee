using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ItemBehavior : MonoBehaviour
{
    public Item Item;
    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _material.SetTexture("_MainText",Item.InGameSprite);
    }

    public void PickUpItem()
    {
        GameManager.InventorySystem.AddItem(Item);
        Destroy(gameObject);
    }
}
