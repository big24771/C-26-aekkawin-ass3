using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Captianamerica : Superhero
{
    // Action Combat
    public void LeapAndJump()
    {
        Debug.Log($"--------{Name} is Leap and Jump!!!");

    }
    public void ThrowShield()
    {
        Debug.Log($"========={Name} is Trowing Shield!!!");

    }
    
    // Action Move
    protected override void Move()
    {
        LeapAndJump();
    }
    protected override void Attack()
    {
        ThrowShield();
    }
    
    public override void Start()
    {
        base.Start();
        Move();
        Attack();
    }
}
