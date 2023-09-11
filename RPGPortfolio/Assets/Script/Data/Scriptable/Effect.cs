using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Effect", menuName = "ScriptableObject/Data/Unit", order = int.MaxValue)]
public class Effect : MonoBehaviour
{
    [SerializeField]
    string effectid;
    public string EffectID { get { return effectid; } set { effectid = value; } }

    [SerializeField]
    int effectvalue;
    public int Value { get { return effectvalue; } set { effectvalue = value; } }

    // ¿Ã∆Â∆Æ « ø‰
}
