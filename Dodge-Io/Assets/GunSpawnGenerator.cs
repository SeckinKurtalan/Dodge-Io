using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawnGenerator : MonoBehaviour
{
    public int CurrentGunDamage;
    public int CurrentGunRange;
    public string CurrentGunName="Empty";
    [SerializeField] BossStatusController bossControllerScript;

    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurrentGunName);
        if(CurrentGunName != "Empty")
        {
            
            CurrentGunName = "Empty";
        }
    }


    void Fire(string gunName)
    {

        //bossControllerScript.health -= CurrentGun.Damage;
    
    }
    
    
    IEnumerator wait()
    {

        while (true)
        {
            yield return new WaitForSeconds(3f);
        }
        

    }
}
