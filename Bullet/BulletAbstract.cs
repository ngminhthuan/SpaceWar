using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletAbstract : ThuanMonoBehaviour
{
    [Header("Bullet Controller")]
    [SerializeField] protected BulletController bulletController;

    public BulletController BulletController { get => bulletController; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBulletController();
    }

    protected virtual void LoadBulletController()
    {
        if (this.bulletController != null) return;
        this.bulletController = transform.parent.GetComponent<BulletController>();
        Debug.Log(transform.name + ": Load Bullet Controller", gameObject);
    }

    protected abstract void OnTriggerEnter2D(Collider2D collision);
}
