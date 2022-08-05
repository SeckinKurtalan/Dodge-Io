using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GunShooter : MonoBehaviour
{
    [HideInInspector] public string firingGunName = "None";

    [HideInInspector] public GameObject firingGunAnim;
    
    [SerializeField] GunSpecGenerator[] guns;
    
    [SerializeField] BossStatusController bossScript;

    [SerializeField] GameObject[] gunsForHolding;
    
    int firingGunDamage=0;
    
    float firingGunRange=0;
    
    [SerializeField] GunPicker pickStatusScript;
    
    [SerializeField] GameObject currentGunOnTheList;

    [SerializeField] PlayerMovement animatorBringer;

    [SerializeField] BoxCollider playerBoxCollider;

    [SerializeField] GameObject[] animationList;


    public void PullTheGunSpecs()
    {
        for(int i = 0; i < guns.Length; i++)
        {
            if (firingGunName == guns[i].GunName)
            {
                firingGunDamage = guns[i].GunDamage;
                firingGunRange = guns[i].GunRange;
                firingGunAnim = guns[i].muzzleFlash;
                
            }
        }
    }

    public void PullTheAnimation()
    {
        for (int i = 0; i < guns.Length; i++)
        {
            if (firingGunName + "Anim" == animationList[i].name)
            {
                firingGunAnim = animationList[i];

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
                if(obj.name == firingGunName)
                {
                    currentGunOnTheList = obj;
                }
            }
        }
        
        StartCoroutine(InvokeTheShootingAnimation());
        currentGunOnTheList.SetActive(true);
        InvokeTheShootingAnimation();
        playerBoxCollider.enabled = false;
        yield return new WaitForSecondsRealtime(3f);
        currentGunOnTheList.SetActive(false);
        animatorBringer.anim.SetLayerWeight(1, 0);
        playerBoxCollider.enabled = true;
    }

    public IEnumerator InvokeTheShootingAnimation()
    {
        firingGunAnim.SetActive(true);
        firingGunAnim.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSecondsRealtime(3f);
        firingGunAnim.GetComponent<ParticleSystem>().Stop();

    }
        
    public void Fire()
    {
        PullTheGunSpecs();
        PullTheAnimation();
        StartCoroutine(InvokeTheShootingAnimation());
        DamageTheBoss();
        StartCoroutine(gunHold());
    }


}
