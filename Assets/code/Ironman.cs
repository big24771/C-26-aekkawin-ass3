using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ironman : Superhero
{
    // Action Combat
    public void Fly()
    {
        Debug.Log($"--------{Name} is Flying!!!");
    }
    public void ShootLaser()
    {
        Debug.Log($"========{Name} is Shooting Lasers!");
    }
    // Action Move
    protected override void Move()
    {
        Fly();
    }
    protected override void Attack()
    {
        ShootLaser();
    }
   
    //Start method
    public override void Start()
    {
        base.Start();
        Move();
        Attack();
    }

}
