using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageSender : DamageSender
{
    [Header("Bullet Controller")]
    [SerializeField] protected BulletController bulletController;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBulletController();
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.Damage = 1;
    }
    
    protected virtual void LoadBulletController()
    {
        if (this.bulletController != null) return;
        this.bulletController = transform.parent.GetComponent<BulletController>();
        Debug.Log(transform.name + ": LoadBulletController ", gameObject);
    }

    public override void Send(DamageReceiver damageReceiver)
    {
        
        base.Send(damageReceiver);
        this.DestroyBullet();
        Debug.Log("Send Damage");
    }


    protected virtual void DestroyBullet()
    {
        this.bulletController.BulletDespawn.DespawnObject();
    }
}
