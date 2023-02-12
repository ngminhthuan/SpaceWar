using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class FxDespawn : DespawnByTime
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.ResetTimer();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        this.ResetTimer();
    }

    protected virtual void ResetTimer()
    {
        this.Timer = 0f;
    }
    public override void DespawnObject()
    {
        FxSpawner.Instance.Despawn(transform.parent);
        
    }
     
}
