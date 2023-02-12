using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
    [SerializeField] protected float Delay = 1f;

    [SerializeField] protected float Timer = 0;

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    protected override bool CanDespawn()
    {
        this.Timer += Time.fixedDeltaTime ;
        if (this.Timer > this.Delay) return true;
        return false;
    }
}
