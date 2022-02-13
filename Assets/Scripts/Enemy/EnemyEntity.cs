using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : BaseEntity
{
    protected override void EntityDead()
    {
       Debug.Log("Dead!!!");
    }
}
