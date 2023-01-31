using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : ThuanMonoBehaviour
{
    [SerializeField] protected JunkSpawnerController junkController;
    [SerializeField] protected float JunkSpawnDelay = 5f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkController();
    }

    protected virtual void LoadJunkController()
    {
        if (this.junkController != null) return;
        this.junkController = GetComponent<JunkSpawnerController>();
        Debug.Log(transform.name + ": Load Junk Controller ", gameObject);
    }

    protected override void Start()
    {
        this.JunkSpawning();
    }

    protected virtual void JunkSpawning()
    {
        Transform ranPoint = this.junkController.JunkSpawnPoints.GetRandomSpawnPoint();
        Vector3 JunkPos = ranPoint.position;
        Quaternion rotation = transform.rotation;

        Transform randomJunk = this.junkController.JunkSpawner.RandomPrefab();
        Transform junkObj = this.junkController.JunkSpawner.Spawn(randomJunk.name, JunkPos, rotation);
        junkObj.gameObject.SetActive(true);
        Invoke(nameof(this.JunkSpawning), JunkSpawnDelay);
    }
}
