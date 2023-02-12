using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : ThuanMonoBehaviour
{
    [Header("Bullet Despawn")]
    [SerializeField] protected BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn { get => bulletDespawn; }

    [Header("Bullet Damage Sender")]
    [SerializeField] protected BulletDamageSender bulletDamageSender;
    public BulletDamageSender BulletDamageSender { get => bulletDamageSender; }

    [Header("Bullet Shooter")]
    [SerializeField] protected Transform bulletShooter;
    public Transform BulletShooter { get => bulletShooter; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBulletDespawn();
        this.LoadBulletDamageSender();
    }

    protected virtual void LoadBulletDespawn()
    {
        if (this.bulletDespawn != null) return;
        bulletDespawn = GetComponentInChildren<BulletDespawn>();
        Debug.Log(transform.name + ": LoadBulletDespawn", gameObject);
    }

    protected virtual void LoadBulletDamageSender()
    {
        if (this.bulletDamageSender != null) return;
        bulletDamageSender = GetComponentInChildren<BulletDamageSender>();
        Debug.Log(transform.name + ": LoadBulletDamageSender ", gameObject);

    }

    public virtual void SetShooter(Transform shooter)
    {
        this.bulletShooter = shooter;
    }
}
