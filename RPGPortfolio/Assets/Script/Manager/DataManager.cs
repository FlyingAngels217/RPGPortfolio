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

    // 번들 로드
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
            L_Units.Add(TempUnits.units[i]);
        }

        bundleRequest = bundle.LoadAssetAsync<SkillList>("SkillList");

        yield return bundleRequest;

        SkillList TempSkills = (SkillList)bundleRequest.asset;

        for(int i = 0; i < TempSkills.skills.Count; i++)
        {
            L_Skills.Add(TempSkills.skills[i]);
        }

        bundleRequest = bundle.LoadAssetAsync<EffectList>("EffectList");

        yield return bundleRequest;

        EffectList TempEffects = (EffectList)bundleRequest.asset;

        for(int i = 0; i < TempEffects.effects.Count; i++)
        {
            L_Effects.Add(TempEffects.effects[i]);
        }
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
