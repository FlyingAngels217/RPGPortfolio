using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : ScriptableObject
{
    [SerializeField]
    string nameid;
    public string NameId { get { return nameid; } set { nameid = value; } }

    [SerializeField]
    string descriptionid;
    public string DescriptionId { get { return descriptionid; } set { descriptionid= value; } }

    [SerializeField]
    int needmp;
    public int NeedMp { get { return needmp; } set { needmp = value; } }

    [SerializeField]
    List<Effect> effects;
    public List<Effect> Effects { get { return effects; } set { effects = value; } }

    // ����Ʈ �ʿ�
}