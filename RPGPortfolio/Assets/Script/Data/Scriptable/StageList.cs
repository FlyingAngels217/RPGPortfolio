using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "List", menuName = "ScriptableObject/Stage/List", order = int.MaxValue)]
public class StageList : ScriptableObject
{
    [SerializeField]
    List<StageInfo> stageinfo;

    public List<StageInfo> StageInfo { get { return stageinfo; } set { stageinfo = value; } }
}
