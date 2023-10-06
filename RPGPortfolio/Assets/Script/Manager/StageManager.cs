using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    List<StageInfo> StageData;

    List<Object> LoadObjects;

    public void StageDataSetting(List<StageInfo> data)
    {
        StageData = data;
    }

    public void LoadStageData(int stage)
    {
        StageData.Clear();

        for(int i = 0; i < StageData[stage].PosInfo.Count; i++)
        {
            CreateStageUnit(StageData[stage].PosInfo[i]);
        }
    }

    private void CreateStageUnit(PosInfo info)
    {
        GameObject temp = new GameObject();

        temp.name = info.UnitInfo.name;
        temp.transform.position = info.Pos;
        temp.gameObject.SetActive(info.Active);

        Instantiate(temp);

        LoadObjects.Add(temp);
    }
}
