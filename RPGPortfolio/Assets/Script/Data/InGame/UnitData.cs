using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitData : MonoBehaviour
{
    GameObject Model;

    string sName;
    FLAG eFlag;

    int nBaseHP;
    int nCurrHP;
    int nBaseMP;
    int nCurrMP;

    int nBaseATK;
    int nCurrATK;
    int nBaseDEF;
    int nCurrDEF;

    Animator UnitAnimator;

    List<SkillData> L_Skills;

    public void UnitDataSetting(Unit unit)
    {
        UnitAnimator = GetComponent<Animator>();

        Model = unit.ObjectModel;
        sName = unit.NameId;
        eFlag = unit.Flag;

        nBaseHP = unit.BaseHp;
        nBaseMP = unit.BaseMp;
        nBaseATK = unit.BaseAtk;
        nBaseDEF = unit.BaseDef;

        L_Skills = new List<SkillData>();

        for(int i = 0; i < unit.Skills.Count; i++)
        {
            L_Skills.Add(L_Skills[i]);
        }
    }

    abstract public void Idle();

    abstract public void Move();

    abstract public void Attack();

    abstract public void Death();
}
