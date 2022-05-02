using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float WalkSpeed;
    public float RunSpeed;

    protected Rigidbody _rigidbody;

    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    protected virtual void Update()
    {

    }

    protected virtual void Walk(Vector2 vector)
    {

        _rigidbody.velocity = new Vector3(vector.x * WalkSpeed, _rigidbody.velocity.y, vector.y * WalkSpeed);
    }

    protected virtual void Run(Vector2 vector)
    {
        _rigidbody.velocity = new Vector3(vector.x * RunSpeed, _rigidbody.velocity.y, vector.y * RunSpeed);
    }

    protected virtual void Attack()
    {

    }


}
