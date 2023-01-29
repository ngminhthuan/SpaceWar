using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    private static BulletSpawner instance;
    public static BulletSpawner Instance { get => instance; }

    public static string bullet1 = "Bullet_1";
    
    protected override void Awake()
    {
        if(BulletSpawner.instance != null) Debug.LogError("Only 1 BulletSpawner allow to exist");
        BulletSpawner.instance = this;
    }


    protected override void LoadHodler()
    {
        if (this.holder != null) return;
        this.holder = transform.Find("BulletHolder");
        Debug.Log(transform.name + ": Load Bullet Hodler", gameObject);
    }

    protected override void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) return;

        Transform prefabObj = transform.Find("BulletPrefabs");
        foreach (Transform prefab in prefabObj)
        {
            this.prefabs.Add(prefab);
        }
        this.HidePrefabs();
        Debug.Log(transform.name + ": Load Bullet Prefabs", gameObject);
    }
}
