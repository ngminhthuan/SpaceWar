using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{ 
private static JunkSpawner instance;
public static JunkSpawner Instance { get => instance; }

public static string meteorite1 = "Meteorite_1";

protected override void Awake()
{
    if (JunkSpawner.instance != null) Debug.LogError("Only 1 JunkSpawner allow to exist");
    JunkSpawner.instance = this;
}


protected override void LoadHodler()
{
    if (this.holder != null) return;
    this.holder = transform.Find("JunkHolder");
    Debug.Log(transform.name + ": Load Junk Hodler", gameObject);
}

protected override void LoadPrefabs()
{
    if (this.prefabs.Count > 0) return;

    Transform prefabObj = transform.Find("JunkPrefabs");
    foreach (Transform prefab in prefabObj)
    {
        this.prefabs.Add(prefab);
    }
    this.HidePrefabs();
    Debug.Log(transform.name + ": Load Junk Prefabs", gameObject);
}
}
