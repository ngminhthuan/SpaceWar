using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : ThuanMonoBehaviour
{
    private static DropManager instance;
    public static DropManager Instance { get => instance; }


    protected override void Awake()
    {
        if (DropManager.instance != null) Debug.LogError("Only 1 DropManager allow to exist");
        DropManager.instance = this;
    }

    public virtual void Drop(List<DropRate> dropitemslist)
    {
        foreach (DropRate item in dropitemslist)
        {
            Debug.Log(item.itemSO.itemName);
        }
    }
}
