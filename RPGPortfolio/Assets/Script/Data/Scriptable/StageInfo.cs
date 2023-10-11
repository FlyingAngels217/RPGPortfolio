using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stage", menuName = "ScriptableObject/Stage/Stage", order = int.MaxValue)]
public class StageInfo : ScriptableObject
{
    [SerializeField]
    List<PosInfo> posinfo;
    public List<PosInfo> PosInfo { get { return posinfo; } set { posinfo = value; } }
}
