using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [Header("Assets")]
    public Texture InGameSprite;
    public Sprite UISprite;

    [Header("Properties")]
    public bool IsStackable;
    public int MaxStackCount = 9;

    public virtual void ExecuteAffect()
    {
        throw new NotImplementedException("Child of Item Class did not override ExecuteAffect");
    }
}
