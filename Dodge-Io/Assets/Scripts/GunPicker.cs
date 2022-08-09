using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GunPicker : MonoBehaviour
{
    public string CurrentCollidingGun = "None";

    [SerializeField] GunSpawnGenerator gunSpawnCountController;
    
    [SerializeField] GunShooter GameManagerShooter;

    public UnityEvent pickUpGun;

    UIWeapons changeUI;
    public bool gunPickStatus;

    [SerializeField] PlayerMovement animatorBringer;

    [SerializeField] GameObject noGunCamera;

    [SerializeField] GameObject aimCamera;
    
    void Start()
    {
        noGunCamera.SetActive(true);
        aimCamera.SetActive(false);
    }

    
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Gun")
        {
            gunPickStatus = true;
            CurrentCollidingGun = collider.gameObject.name;
            UIWeapons.silah = CurrentCollidingGun;
            UIWeapons.hand = gunPickStatus;

            GameObject.Find("Current").GetComponent<UIWeapons>().ChangeWeapon();

            collider.gameObject.SetActive(false);
            pickUpGun.Invoke();
            gunSpawnCountController.spawnCount--;
            int listCount = gunSpawnCountController.spawnedGuns.Count;
            gunSpawnCountController.spawnedGuns.RemoveAt(listCount - 1);
        }


    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Gun")
        {
            gunPickStatus = false;
            UIWeapons.hand = gunPickStatus;
            GameObject.Find("Current").GetComponent<UIWeapons>().ChangeWeapon();
            CurrentCollidingGun = "None";
        }
    }


    public void PassTheGunName()
    {
        GameManagerShooter.firingGunName = CurrentCollidingGun;
        
    }


    public IEnumerator NoGunCameraSetter()
    {
        yield return new WaitForSecondsRealtime(3f);
        noGunCamera.SetActive(true);
        aimCamera.SetActive(false);
    }


    public void AimCameraSetter()
    {
        noGunCamera.SetActive(false);
        aimCamera.SetActive(true);
        StartCoroutine(NoGunCameraSetter());
    }
}
