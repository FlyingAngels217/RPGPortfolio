using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Effect", menuName = "ScriptableObject/Data/Effect", order = int.MaxValue)]
public class Effect : ScriptableObject
{
    [SerializeField]
    string effectid;
    public string EffectID { get { return effectid; } set { effectid = value; } }

    [SerializeField]
    int effectvalue;
    public int Value { get { return effectvalue; } set { effectvalue = value; } }

    // ¿Ã∆Â∆Æ « ø‰
}
