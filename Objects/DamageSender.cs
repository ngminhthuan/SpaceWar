using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : ThuanMonoBehaviour
{
    [Header("Damage")]
    [SerializeField] protected float Damage=1;

    public virtual void Send(Transform obj)
    {
        DamageReceiver damageReceiver = obj.GetComponent<DamageReceiver>();
        if (damageReceiver == null) return;
        Debug.Log("hit");
        this.Send(damageReceiver);
    }


    public virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.Damage);
    } 
}
