using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkController : ThuanMonoBehaviour
{
    [Header("Model")]
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }

    [Header("Junk Despawn")]
    [SerializeField] protected JunkDespawn junkDespawn;
    public JunkDespawn JunkDespawn { get => junkDespawn; }

    [Header("Junk Damage Receiver")]
    [SerializeField] protected JunkDamageReceiver junkDamageReceiver;
    public JunkDamageReceiver JunkDamageReceiver { get => junkDamageReceiver; }

    [Header("Junk Animation")]
    [SerializeField] protected JunkAnimation junkAnimation;
    public JunkAnimation JunkAnimation { get => junkAnimation; }

    [SerializeField] protected JunkSO junkSO;

    public JunkSO JunkSO => junkSO;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
        this.LoadJunkDespawn();
        this.LoadJunkAnimation();
        this.LoadJunkDamageReceiver();
        this.LoadJunkSO();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": Load Model", gameObject);
    }

    protected virtual void LoadJunkDespawn()
    {
        if (this.junkDespawn != null) return;
        this.junkDespawn = GetComponentInChildren<JunkDespawn>();
        Debug.Log(transform.name + ": Load JunkDespawn", gameObject);
    }
    protected virtual void LoadJunkAnimation()
    {
        if (this.junkAnimation != null) return;
        this.junkAnimation = GetComponentInChildren<JunkAnimation>();
        Debug.Log(transform.name + ": Load JunkAnimation", gameObject);
    }

    protected virtual void LoadJunkDamageReceiver()
    {
        if (this.junkDamageReceiver != null) return;
        this.junkDamageReceiver = GetComponentInChildren<JunkDamageReceiver>();
        Debug.Log(transform.name + ": Load JunkDamageReceiver", gameObject);
    }

    protected virtual void LoadJunkSO()
    {
        if (this.junkSO != null) return;
        string resPath = "Junk/" + transform.name;
        this.junkSO = Resources.Load<JunkSO>(resPath);
        Debug.LogWarning(transform.name + ": LoadJunkSO", gameObject);
    }
}
