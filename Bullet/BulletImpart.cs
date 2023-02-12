using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BulletImpart : BulletAbstract
{
    [Header("Bullet Collider")]
    [SerializeField] protected PolygonCollider2D polygonCollider2D;

    [Header("Bullet Rigidbody2D")]
    [SerializeField] protected Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
        this.LoadRigidBody2D();
    }

    protected virtual void LoadCollider()
    {
        if (this.polygonCollider2D != null) return;
        this.polygonCollider2D = GetComponent<PolygonCollider2D>();
        this.polygonCollider2D.isTrigger = true;
        Debug.Log(transform.name + ": LoadCollider", gameObject);
    }

    protected virtual void LoadRigidBody2D()
    {
        if (this._rigidbody2D != null) return;
        this._rigidbody2D = GetComponent<Rigidbody2D>();
        this._rigidbody2D.isKinematic = true;
        this._rigidbody2D.freezeRotation = true;
        this._rigidbody2D.gravityScale = 0;
        Debug.Log(transform.name + ": LoadRigidBody2D", gameObject);
    }
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.parent == this.bulletController.BulletShooter) return;

        this.OnBulletImpactFx();
        BulletController.BulletDamageSender.Send(other.transform);
        
    }

    

    protected virtual void OnBulletImpactFx()
    {
        string fxname = this.GetBulletImpactFxName();

        //Get this position and the rotation of bullet in the Contact time
        Vector3 hitPos = transform.position;
        Quaternion hitRot = transform.rotation;

        Transform fxOnBullet = FxSpawner.Instance.Spawn(fxname, hitPos, hitRot);
        fxOnBullet.gameObject.SetActive(true);
    }

    protected virtual string GetBulletImpactFxName()
    {
        return FxSpawner.bulletImpactFx1;
    }
}
