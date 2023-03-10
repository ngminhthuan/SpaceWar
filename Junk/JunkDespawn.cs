using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawn : DespawnByDistance
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.maxDistance = 40f;
    }

    protected virtual void Reborn()
    {
        this.currentDistance = 0f;
    } 
    protected override void OnEnable()
    {
        base.OnEnable();
        this.currentDistance = 0f;
    }
    public override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
}
