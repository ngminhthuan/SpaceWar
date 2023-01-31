using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnPoints : SpawnPoints
{
    protected override void LoadSpawnPoints()
    {
        if (this.points.Count > 0) return;

        Transform prefabObj = transform.Find("JunkSpawnPoints");
        foreach (Transform point in prefabObj)
        {
            this.points.Add(point);
        }
        Debug.Log(transform.name + ": Load JunkSpawnPoints", gameObject);
    }
}
