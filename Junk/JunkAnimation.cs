using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkAnimation : ThuanMonoBehaviour
{
    [SerializeField] protected Animator junkAnimator;
    public Animator JunkAnimator { get => junkAnimator; }

    protected override void Reset()
    {
        base.Reset();
        this.LoadJunkAnimation();
    }

    protected virtual void LoadJunkAnimation()
    {
        if (this.junkAnimator != null) return;
        junkAnimator = GetComponent<Animator>();
        Debug.Log(transform.name + " : Load Junk Animation",gameObject);
    }

    public virtual void JunkExplode(bool isDead)
    {
        JunkAnimator.SetBool("IsDead", isDead);
    }



}
