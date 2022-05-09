using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CustomScriptables/Weapons")]
public class WeaponAssetPack : ScriptableObject
{
    public Texture2D WeaponSprite;

    public GameObject Bullet;

    public AudioClip ShootSFX;

    public AudioClip ReloadSFX;

    public AudioClip EquipSFX;

}
