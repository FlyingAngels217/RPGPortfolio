using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Info", menuName = "ScriptableObject/Stage/Info", order = int.MaxValue)]
public class PosInfo : ScriptableObject
{
    [SerializeField]
    Unit unit;
    public Unit UnitInfo { get { return unit; } set { unit = value; } }

    [SerializeField]
    Vector3 pos;
    public Vector3 Pos { get { return pos; } set { pos = value; } }

    [SerializeField]
    bool active;
    public bool Active { get { return active; } set { active = value; } }
}