using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunSpecs : MonoBehaviour
{
    [SerializeField] GunSpawnGenerator gunSpawnerScript;
    [SerializeField] int Damage;
    [SerializeField] int Range;
    
    string gunName = "Minigun";
    
    bool playerTouchStatus = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerTouchStatus)
        {
            SetCurrentGun();
            gameObject.SetActive(false);
        }
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerTouchStatus = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerTouchStatus = false;
        }
    }

    void SetCurrentGun()
    {
        gunSpawnerScript.CurrentGunName = gunName;
        gunSpawnerScript.CurrentGunDamage = Damage;
        gunSpawnerScript.CurrentGunRange = Range;
    }

    void UnSetCurrentGun()
    {
        gunSpawnerScript.CurrentGunName = "Empty";
    }

    void timer()
    {
        StartCoroutine("wait");
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
    }
}
