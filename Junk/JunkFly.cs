using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ObjectParentFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.MoveSpeed = 0.5f;
    }
}
