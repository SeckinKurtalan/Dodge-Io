using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GunShooter : MonoBehaviour
{
    [HideInInspector] public string firingGunName = "None";

    [SerializeField] GunSpecGenerator[] guns;
    
    [SerializeField] BossStatusController bossScript;
    int firingGunDamage=0;
    float firingGunRange=0;
    [SerializeField] GunPicker pickStatusScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PullTheGunSpecs()
    {
        for(int i = 0; i < guns.Length; i++)
        {
            if (firingGunName == guns[i].GunName)
            {
                firingGunDamage = guns[i].GunDamage;
                firingGunRange = guns[i].GunRange;
            }
        }
    }

    public void DamageTheBoss()
    {
        bossScript.health -= firingGunDamage;
    }
    
    public void Fire()
    {
        PullTheGunSpecs();
        DamageTheBoss();
    }

}
