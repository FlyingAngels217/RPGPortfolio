using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillList", menuName = "ScriptableObject/List/Skills", order = int.MaxValue)]
public class SkillList : ScriptableObject
{
    [SerializeField]
    public List<Skill> skills;
    public List<Skill> Skills { get { return skills; } set { skills = value; } }
}
