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

    // ���� �ε�
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

    // ������ ��ũ - ������ ���¹��� üũ �Ŀ� ȣ��Ǿ�� ��.
    private void DataSetting(List<Effect> effects, List<Skill> skills, List<Unit> units)
    {
        DataReset();

        L_Effects = effects;
        L_Skills = skills;
        L_Units = units;
    }
}
