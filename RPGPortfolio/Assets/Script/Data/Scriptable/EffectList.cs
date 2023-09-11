using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectList", menuName = "ScriptableObject/List/Effects", order = int.MaxValue)]
public class EffectList : MonoBehaviour
{
    [SerializeField]
    public List<Effect> effects;
    public List<Effect> Effects { get { return effects; } set { effects = value; } }
}
