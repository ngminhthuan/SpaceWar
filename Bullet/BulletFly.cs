using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : ObjectParentFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.MoveSpeed = 7f;
    }
}
