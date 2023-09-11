using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitList", menuName = "ScriptableObject/List/Units", order = int.MaxValue)]
public class UnitList : ScriptableObject
{
    [SerializeField]
    public List<Unit> units;
    public List<Unit> Units { get { return units; } set { units = value; } }
}
