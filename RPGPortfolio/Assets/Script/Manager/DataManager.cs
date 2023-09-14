using OpenCover.Framework.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataManager : MonoBehaviour
{
    List<Effect> L_Effects;
    List<Skill> L_Skills;
    List<Unit> L_Units;

    int DebugRand;
    public void Test()
    {
        Debug.Log("DB - " + DebugRand);
    }

    public DataManager()
    {
        DebugRand = UnityEngine.Random.Range(0, 99999);
    }

    public bool LoadStartData()
    {
        DataReset();
        return true;
    }

    // 번들 로드
    private void LoadAssetBundle()
    {
        StartCoroutine(AssetBundleLoadStart());
    }

    IEnumerator AssetBundleLoadStart()
    {
        string url = "file:////" + Application.dataPath + "/AssetBundles/data";
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(url);

        yield return request.SendWebRequest();

        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
        /*
        AssetBundleRequest bundleRequest = bundle.LoadAssetAsync<GameObject>("Stone");

        yield return bundleRequest;
        */
    }

    private void DataReset()
    {
        L_Effects = new List<Effect>();
        L_Skills = new List<Skill>();
        L_Units = new List<Unit>();
    }

    // 데이터 링크 - 무조건 에셋번들 체크 후에 호출되어야 함.
    private void DataSetting(List<Effect> effects, List<Skill> skills, List<Unit> units)
    {
        DataReset();

        L_Effects = effects;
        L_Skills = skills;
        L_Units = units;
    }
}
