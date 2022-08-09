using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageInACertainTimeToPlayer : MonoBehaviour
{
    [SerializeField] PlayerController playerControllerScript;
    [SerializeField] bool isHittible=true;
    [SerializeField] float hitTimeGap;
    [SerializeField] int damageAmount;
    [SerializeField] float theFunctionStartGapAfterStartingTheGame;

    public Image FillImage;

    void Start()
    {
        InvokeRepeating("hittingPlayer", theFunctionStartGapAfterStartingTheGame, hitTimeGap);
    }

    void hittingPlayer()
    {
        if (isHittible)
        {
            playerControllerScript.health -= damageAmount;
            FillImage.fillAmount = playerControllerScript.health/100;
        }
        
    }
    


}
