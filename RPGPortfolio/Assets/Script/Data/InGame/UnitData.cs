using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitData : MonoBehaviour
{
    protected GameObject Model;

    protected string sName;
    protected FLAG eFlag;

    protected int nBaseHP;
    protected int nCurrHP;
    protected int nBaseMP;
    protected int nCurrMP;

    protected int nBaseATK;
    protected int nCurrATK;
    protected int nBaseDEF;
    protected int nCurrDEF;

    protected Animator UnitAnimator;

    protected List<SkillData> L_Skills;

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
