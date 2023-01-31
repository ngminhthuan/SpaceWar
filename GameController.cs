using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : ThuanMonoBehaviour
{
    protected static GameController instance;

    public static GameController Instance { get => instance; }
    
    [SerializeField] protected Camera mainCam;
    public Camera MainCam { get => mainCam; }

    protected override void LoadComponents()
    {
        this.LoadCamera();
    }

    protected override void Start()
    {
        base.Start();
        if (GameController.instance != null) Debug.LogError("Only 1 GameController allow to exist");
        GameController.instance = this;
    }
    protected virtual void LoadCamera()
    {
        if (this.mainCam != null) return;
        this.mainCam = FindObjectOfType<Camera>();
        Debug.Log(transform.name + ": Load Camera", gameObject);
    }
}
