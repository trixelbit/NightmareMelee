using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, IEquipable
{
    public WeaponAssetPack Assets;

    protected Material _material;

    protected virtual void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _material.SetTexture("_MainText", Assets.WeaponSprite);
    }

    public virtual void Equip()
    {
        gameObject.SetActive(true);
    }

    public virtual void Shoot()
    {
        GameObject instance = GameObject.Instantiate(Assets.Bullet);
        instance.transform.position = transform.position;
        instance.transform.rotation =  transform.rotation;
    }

    public virtual void UnEquip()
    {
        gameObject.SetActive(false);
    }
}
