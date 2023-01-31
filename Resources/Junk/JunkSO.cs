using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Junk", menuName ="ScriptableObject/Junk")]
public class JunkSO : ScriptableObject
{
    public string JunkName;
    public int HpMax = 2;
}
