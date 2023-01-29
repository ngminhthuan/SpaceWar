using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float maxDistance = 70f;
    [SerializeField] protected float currentDistance = 0f;
    [SerializeField] protected Camera MainCam;

    protected override void LoadComponents()
    {
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.MainCam != null) return;
        this.MainCam = FindObjectOfType<Camera>();
    }

    protected override bool CanDespawn()
    {
        this.currentDistance = Vector3.Distance(transform.parent.position, MainCam.transform.position);
        if (this.currentDistance > this.maxDistance) return true;
        return false;
    }
}
