using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawn : DespawnByDistance
{
    protected override void ResetValue()
    {
        this.maxDistance = 40f;
    }
    public override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
}
