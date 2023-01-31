using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbstract
{
    [SerializeField] protected float speed = 9f;

    protected override void FixedUpdate()
    {
        this.Rotating();
    }

    protected virtual void Rotating()
    {
        Vector3 eulers = new Vector3(0, 0, 1f);
        this.junkController.Model.Rotate(eulers * this.speed * Time.fixedDeltaTime);
        this.junkController.JunkDamageReceiver.transform.Rotate(eulers * this.speed * Time.fixedDeltaTime);
    }
}
