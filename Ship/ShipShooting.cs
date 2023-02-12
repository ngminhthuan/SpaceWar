using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected float ShootingDelay = 1f;
    [SerializeField] protected float ShootingTimer = 0f;
    protected void FixedUpdate()
    {
        this.CheckShoot();
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        if (!this.isShooting) return;

        this.ShootingTimer += Time.fixedDeltaTime;
        if (this.ShootingTimer < this.ShootingDelay) return;
        this.ShootingTimer = 0f;

        Vector3 spawnPos = transform.position;
        Quaternion rotation = transform.parent.rotation;
        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.bullet1,spawnPos, rotation);
        if (newBullet == null) return;

        newBullet.gameObject.SetActive(true);

        BulletController bulletController = newBullet.GetComponent<BulletController>();
        bulletController.SetShooter(transform.parent);
    }

    protected virtual bool CheckShoot()
    {
        isShooting = InputManager.Instance.OnFiring == 1;
        return isShooting;
    }
}
