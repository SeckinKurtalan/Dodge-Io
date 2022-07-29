using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GunPicker : MonoBehaviour
{
    public string CurrentCollidingGun = "None";

    [SerializeField] GunShooter GameManagerShooter;

    public UnityEvent pickUpGun;

    public bool gunPickStatus;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
         if(collider.gameObject.tag == "Gun")
        {
            gunPickStatus = true;
            CurrentCollidingGun = collider.gameObject.name;
            collider.gameObject.SetActive(false);
            pickUpGun.Invoke();
        }
            

    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Gun")
        {
            gunPickStatus = false;
            CurrentCollidingGun = "None";
        }
    }


    public void PassTheGunName()
    {
        GameManagerShooter.firingGunName = CurrentCollidingGun;
        
    }

}
