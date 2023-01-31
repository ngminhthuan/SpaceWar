using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerController : ThuanMonoBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner { get => junkSpawner; }

    [SerializeField] protected JunkSpawnPoints junkSpawnPoints;
    public JunkSpawnPoints JunkSpawnPoints { get => junkSpawnPoints; }

    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();
        this.LoadJunkSpawnerPoints();
    }

    protected virtual void LoadJunkSpawner()
    {
        if (this.junkSpawner != null) return;
        this.junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log(transform.name + ": LoadJunkSpawner ", gameObject);
    }
    protected virtual void LoadJunkSpawnerPoints()
    {
        if (this.junkSpawnPoints != null) return;
        this.junkSpawnPoints = GetComponent<JunkSpawnPoints>();
        Debug.Log(transform.name + ": Load junkSpawnPoints ", gameObject);
    }

    
}
