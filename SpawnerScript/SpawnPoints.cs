using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnPoints : ThuanMonoBehaviour
{
    [SerializeField] protected List<Transform> points;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPoints();
    }

    protected virtual void LoadSpawnPoints()
    {
        if (this.points.Count > 0) return;

        Transform prefabObj = transform.Find("SpawnPoints");
        foreach (Transform point in prefabObj)
        {
            this.points.Add(point);
        }
        Debug.Log(transform.name + ": LoadPoints", gameObject);
    }

    public virtual Transform GetRandomSpawnPoint()
    {
        int rand = Random.Range(0, this.points.Count);
        return this.points[rand];
    }
}
