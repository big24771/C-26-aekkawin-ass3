using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popkung : Superhero
{
    //hahaha Only Popkung
    public void SpecialAbility()
    {
        Debug.Log("Pop kamehamehaaaaa!!!!!");
    }
    public void PopMove()
    {
        Debug.Log("Pop daze !!!!!");

    }
    public void PopAttack()
    {
        Debug.Log("Pop omegaaa punchhhhh!!!!");

    }

    //Combat Move
    protected override void Move()
    {
        PopMove();
    }
    protected override void Attack()
    {
        PopAttack();
    }
    //action start
    public override void Start()
    {
        base.Start();
        Move();
        Attack();
        SpecialAbility();
    }
}
