using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectParentFly : ThuanMonoBehaviour
{
    [SerializeField] protected float MoveSpeed = 1f;
    [SerializeField] protected Vector3 direction = Vector3.right;

    protected override void Update()
    {
        transform.parent.Translate(this.direction * this.MoveSpeed * Time.deltaTime);
    }
}
