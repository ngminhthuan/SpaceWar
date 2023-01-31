using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ObjectParentFly
{
    [SerializeField] protected float RangeXMin = -10;
    [SerializeField] protected float RangeXMax = 10;
    [SerializeField] protected float RangeZMin = -15;
    [SerializeField] protected float RangeZMax = 10;
    protected override void ResetValue()
    {
        base.ResetValue();
        this.MoveSpeed = 3f;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        this.GetFlyDirection();
    }

    protected virtual void GetFlyDirection()
    {
        Vector3 camPos = GameController.Instance.MainCam.transform.position;
        Vector3 objPos = transform.parent.position;

        camPos.x += Random.Range(RangeXMin, RangeXMax);
        camPos.z += Random.Range(RangeZMin, RangeZMax);

        Vector3 diff = camPos - objPos;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y,diff.x)*Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0, 0, rot_z);

        Debug.DrawLine(objPos, objPos + diff * 7, Color.red, Mathf.Infinity);

    }
}
