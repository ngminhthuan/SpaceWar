using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThuanMonoBehaviour : MonoBehaviour
{

    protected virtual void Reset()
    {
        this.LoadComponents();
        this.ResetValue();
    }

    protected virtual void Awake()
    {
        this.LoadComponents();
        this.ResetValue();
    }

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }

    protected virtual void FixedUpdate()
    {

    }

    protected virtual void LoadComponents()
    {
        // for override
    }

    protected virtual void ResetValue()
    {

    }

}
