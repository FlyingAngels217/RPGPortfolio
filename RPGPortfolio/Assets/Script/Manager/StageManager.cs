using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    List<StageInfo> StageData;

    public void LoadStageData(int stage)
    {
        for(int i = 0; i < StageData[stage].PosInfo.Count; i++)
        {
            // 배치 및 활성화
        }
    }
}
