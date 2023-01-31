using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : ThuanMonoBehaviour
{
    [SerializeField] protected float CurrentHP;
    [SerializeField] protected float MaxHP;
    [SerializeField] protected bool isDead = false;

    protected override void ResetValue()
    {
        base.ResetValue();
        this.Reborn();
    }

    public virtual void Reborn()
    {
        this.CurrentHP = this.MaxHP;
        this.isDead = false;
    }

    public virtual void Add(float add)
    {
        if (this.isDead) return;

        this.CurrentHP += add;
        if (this.CurrentHP > this.MaxHP) this.CurrentHP = this.MaxHP;
    }

    public virtual void Deduct(float deduct)
    {
        if (this.isDead) return;

        this.CurrentHP -= deduct;
        if (this.CurrentHP < 0) this.CurrentHP = 0;
        this.CheckIsDead();
    }

    public virtual bool IsDead()
    {
        if (this.CurrentHP <= 0) return true;
        return false;
    }

    protected virtual void CheckIsDead()
    {
        if (!this.IsDead()) return;
        this.isDead = true;
        
        this.OnDead();
    }

    protected virtual void OnDead()
    {
      
    }
    
}
