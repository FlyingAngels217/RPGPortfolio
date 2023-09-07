using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitData : MonoBehaviour
{
    string sName;
    FLAG eFlag;
    Animator AnimatorModel;

    int nBaseHP;
    int nCurrHP;
    int nBaseMP;
    int nCurrMP;

    int nBaseATK;
    int nCurrATK;
    int nBaseDEF;
    int nCurrDEF;

    List<SkillData> L_Skills;

    virtual public void Idle()
    {

    }

    virtual public void Move()
    {

    }

    virtual public void Attack()
    {

    }

    virtual public void Death()
    {

    }
}
