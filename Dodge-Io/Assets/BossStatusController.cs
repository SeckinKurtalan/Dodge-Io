using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStatusController : MonoBehaviour
{
    [HideInInspector]
    public int health=100;
    int x = 100;
    int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(health != x)
        {
            Debug.Log(health);
            x = health;
        }
    }

    
    
}
