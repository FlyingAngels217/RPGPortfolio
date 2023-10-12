using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "ScriptableObject/Data/Skill", order = int.MaxValue)]
public class Skill : ScriptableObject
{
    [SerializeField]
    string id;
    public string ID { get { return id; } set { id = value; } }

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

    // ¿Ã∆Â∆Æ « ø‰
}
