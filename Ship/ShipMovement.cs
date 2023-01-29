using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected float MoveSpeed = 0.1f;
    [SerializeField] protected Vector3 TargetPosition;
    private float RotateDeg;

    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        this.GetTargetPosition();
        this.Moving();
        this.LootAtTarget();
    }

    protected virtual void GetTargetPosition()
    {
        this.TargetPosition = InputManager.Instance.MouseWorldPos;
        this.TargetPosition.z = 0;
        
        
        
    }

    protected virtual void LootAtTarget()
    {
        Vector3 diff = this.TargetPosition - transform.parent.position;
        diff = diff.normalized;
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        
        if (TargetPosition != transform.position)
        {
            RotateDeg = rot_z;
            transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);
        }
        else
        {
            transform.parent.rotation = Quaternion.Euler(0f, 0f, RotateDeg);
        }
        

    }

    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, TargetPosition, this.MoveSpeed);
        transform.parent.position = newPos;

    }

}
