using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStatusController : MonoBehaviour
{
    [HideInInspector]
    public int health=100; 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseTheBossHealth(int decreaseAmount)
    {
        health = decreaseAmount;
    }
    
}
