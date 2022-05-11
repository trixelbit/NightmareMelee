using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public static float LifeTime = 5;

    protected void Start()
    {
        StartCoroutine(Expire(LifeTime));
    }

    protected void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    //TODO: Switch To ObjectPulling System;
    protected IEnumerator Expire(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
