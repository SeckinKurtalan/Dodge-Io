using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GunShooter : MonoBehaviour
{
    [HideInInspector] public string firingGunName = "None";

    [SerializeField] GunSpecGenerator[] guns;
    
    [SerializeField] BossStatusController bossScript;

    [SerializeField] GameObject[] gunsForHolding;
    int firingGunDamage=0;
    float firingGunRange=0;
    [SerializeField] GunPicker pickStatusScript;
    
    [SerializeField] GameObject currentGunOnTheList;

    [SerializeField] PlayerMovement animatorBringer;

    [SerializeField] BoxCollider playerBoxCollider;

    
    void Awake()
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
            if (firingGunName == guns[i].GunName + "(Clone)")
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
    
    

    IEnumerator gunHold()
    {
        for(int i = 0; i < gunsForHolding.Length; i++)
        {
            foreach(GameObject obj in gunsForHolding)
            {
                if(obj.name + "(Clone)" == firingGunName)
                {
                    currentGunOnTheList = obj;
                }
            }
        }
        currentGunOnTheList.SetActive(true);
        playerBoxCollider.enabled = false;
        yield return new WaitForSecondsRealtime(3f);
        currentGunOnTheList.SetActive(false);
        animatorBringer.anim.SetLayerWeight(1, 0);
        playerBoxCollider.enabled = true;
    }
    public void Fire()
    {
        PullTheGunSpecs();
        DamageTheBoss();
        StartCoroutine(gunHold());
    }
}
