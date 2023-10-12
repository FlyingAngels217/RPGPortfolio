using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unit", menuName = "ScriptableObject/Data/Unit", order = int.MaxValue)]
public class Unit : ScriptableObject
{
    [SerializeField]
    string id;
    public string ID { get { return id; } set { id = value; } }

    [SerializeField]
    string nameid;
    public string NameId { get { return nameid; } set { nameid = value; } }

    [SerializeField]
    FLAG flag;
    public FLAG Flag { get { return flag; } set { flag = value; } }

    [SerializeField]
    GameObject objectmodel;
    public GameObject ObjectModel { get { return objectmodel; } set { objectmodel = value; } }

    [SerializeField]
    int basehp;
    public int BaseHp { get { return basehp;} set { basehp = value; } }

    [SerializeField]
    int basemp;
    public int BaseMp { get { return basemp;} set { basemp = value; } }

    [SerializeField]
    int baseatk;
    public int BaseAtk { get { return baseatk; } set { baseatk= value; } }

    [SerializeField]
    int basedef;
    public int BaseDef { get { return basedef; } set { basedef = value; } }

    [SerializeField]
    List<Skill> skills;
    public List<Skill> Skills { get { return skills; } set { skills = value; } }

    // 인벤토리 리스트
}
