using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EffectData : MonoBehaviour
{
    string sEffectID;
    int EffectValue;

    abstract public void ApplyEffect();
}
