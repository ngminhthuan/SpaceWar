using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDamageReceiver : DamageReceiver
{
    [SerializeField] protected JunkController junkController;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkController();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        this.Reborn();
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        this.MaxHP = junkController.JunkSO.HpMax;
    }

    public override void Reborn()
    {
        this.MaxHP = junkController.JunkSO.HpMax;
        base.Reborn();

    }
    protected virtual void LoadJunkController()
    {
        if (junkController != null) return;
        junkController = transform.parent.GetComponent<JunkController>();
        Debug.Log(transform.name + ": Load LoadJunkController", gameObject);
    }

    protected override void OnDead()
    {
        Debug.Log("Dead");
        this.OnDeadFx();
        this.junkController.JunkDespawn.DespawnObject();
        DropManager.Instance.Drop(junkController.JunkSO.dropList);
    }

    protected virtual void OnDeadFx()
    {
        string fxname = this.GetOnDeadFxName();
        Transform fxOnDead = FxSpawner.Instance.Spawn(fxname, transform.position, transform.rotation);
        fxOnDead.gameObject.SetActive(true);
    }

    protected virtual string GetOnDeadFxName()
    {
        return FxSpawner.explodeFx1;
    }
    
}
