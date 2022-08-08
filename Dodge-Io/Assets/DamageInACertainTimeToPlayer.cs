using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageInACertainTimeToPlayer : MonoBehaviour
{
    [SerializeField] PlayerController playerControllerScript;
    [SerializeField] bool isHittible=true;
    [SerializeField] float hitTimeGap;
    [SerializeField] int damageAmount;
    [SerializeField] float theFunctionStartGapAfterStartingTheGame;
    
    void Start()
    {
        InvokeRepeating("hittingPlayer", theFunctionStartGapAfterStartingTheGame, hitTimeGap);
    }

    void hittingPlayer()
    {
        if (isHittible)
        {
            playerControllerScript.health -= damageAmount;
        }
        
    }
    


}
