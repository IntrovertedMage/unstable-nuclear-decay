using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelSettings : ScriptableObject
{
    public new string name;
    public Color color;
    public string[] enemies;
    public float alphaAmount;
    public float alphaTime;
    public float betaAmount;
    public float betaTime;

}
