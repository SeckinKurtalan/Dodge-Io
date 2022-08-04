using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunData", menuName = "GunSpecPasser")]

public class GunSpecGenerator : ScriptableObject
{
    public string GunName;
    public int GunDamage = 0;
    public float GunWeight = 0;
    public float GunRange = 0;
    public ParticleSystem muzzleFlash;
}