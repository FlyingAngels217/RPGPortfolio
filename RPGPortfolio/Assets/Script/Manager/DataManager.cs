using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataManager : MonoBehaviour
{
    Dictionary<string, Effect> Dic_Effects;
    Dictionary<string, Skill> Dic_Skills;
    Dictionary<string, Unit> Dic_Units;

    List<StageInfo> L_Stage;


    Dictionary<string, GameObject> Dic_Building;

    int DebugRand;
    public void Test()
    {
        Debug.Log("DB - " + DebugRand);
    }

    // ���� �ε�
    public void LoadAssetBundle()
    {
        StartCoroutine(AssetBundleLoadStart());
    }

    IEnumerator AssetBundleLoadStart()
    {
        DataReset();

        string url = "file:////" + Application.dataPath + "/AssetBundles/data";
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(url);

        yield return request.SendWebRequest();

        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
        AssetBundleRequest bundleRequest = bundle.LoadAssetAsync<UnitList>("UnitList");

        yield return bundleRequest;

        UnitList TempUnits = (UnitList)bundleRequest.asset;

        for(int i = 0; i < TempUnits.units.Count; i++)
        {
            Dic_Units.Add(TempUnits.units[i].ID, TempUnits.units[i]);
        }

        //

        bundleRequest = bundle.LoadAssetAsync<SkillList>("SkillList");

        yield return bundleRequest;

        SkillList TempSkills = (SkillList)bundleRequest.asset;

        for(int i = 0; i < TempSkills.skills.Count; i++)
        {
            Dic_Skills.Add(TempSkills.skills[i].ID, TempSkills.skills[i]);
        }

        //

        bundleRequest = bundle.LoadAssetAsync<EffectList>("EffectList");

        yield return bundleRequest;

        EffectList TempEffects = (EffectList)bundleRequest.asset;

        for(int i = 0; i < TempEffects.effects.Count; i++)
        {
            Dic_Effects.Add(TempEffects.effects[i].ID, TempEffects.effects[i]);
        }

        //

        bundleRequest = bundle.LoadAssetAsync<StageInfo>("StageData");

        yield return bundleRequest;

        StageList TempStage = (StageList)bundleRequest.asset;

        for(int i = 0; i < TempStage.StageInfo.Count; i++)
        {
            L_Stage.Add(TempStage.StageInfo[i]);
        }

        //


    }

    private void DataReset()
    {
        Dic_Effects = new Dictionary<string, Effect>();
        Dic_Skills = new Dictionary<string, Skill>();
        Dic_Units = new Dictionary<string, Unit>();
    }

    // ������ ��ũ - ������ ���¹��� üũ �Ŀ� ȣ��Ǿ�� ��.
    private void DataSetting(List<Effect> effects, List<Skill> skills, List<Unit> units)
    {
        DataReset();

        //L_Effects = effects;
        //L_Skills = skills;
        //L_Units = units;
    }
}
