using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayStatus : MonoBehaviour
{
    [SerializeField] GunPicker gunPickStatusController;

    [SerializeField] GameObject firePrefab;
    void Start()
    {
        firePrefab.SetActive(false);
    }

    IEnumerator SetFireOn()
    {
        if(gunPickStatusController.CurrentCollidingGun == "FlameThrower")
        {
            firePrefab.SetActive(true);
            yield return new WaitForSecondsRealtime(3f);
            firePrefab.SetActive(false);
        }
    }
}
