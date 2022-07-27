using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDestroyer : MonoBehaviour
{
    
    RingSpawner ringCountScript;
    
    bool ringTouchStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        ringCountScript = GameObject.Find("Game Controller").GetComponent<RingSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOnTouch();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            ringTouchStatus = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            ringTouchStatus = false;
        }
    }


    void DestroyOnTouch()
    {
        if (ringTouchStatus)
        {
            Destroy(gameObject);
            ringCountScript.ringCount--;
        }
    }

}
