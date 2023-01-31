using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxSpawner : Spawner
{
    private static FxSpawner instance;
    public static FxSpawner Instance { get => instance; }

    public static string FX1 = "Explode_fire";

    protected override void Awake()
    {
        if (FxSpawner.instance != null) Debug.LogError("Only 1 FxSpawner allow to exist");
        FxSpawner.instance = this;
    }


    protected override void LoadHodler()
    {
        if (this.holder != null) return;
        this.holder = transform.Find("FxHolder");
        Debug.Log(transform.name + ": Load Fx Hodler", gameObject);
    }

    protected override void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) return;

        Transform prefabObj = transform.Find("FxPrefabs");
        foreach (Transform prefab in prefabObj)
        {
            this.prefabs.Add(prefab);
        }
        this.HidePrefabs();
        Debug.Log(transform.name + ": Load Fx Prefabs", gameObject);
    }
}
