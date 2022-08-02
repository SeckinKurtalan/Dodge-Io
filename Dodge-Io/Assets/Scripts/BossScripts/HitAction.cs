using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAction : MonoBehaviour
{
    public GameObject player;
    private bool hitStatus=false;
    public bool GameOverStatus = false;   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HitControl();
    }


    private void OnTriggerEnter(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            hitStatus = true;
        }

    }
    
    private void OnTriggerExit(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            hitStatus = false;
        }
    }


    void GameOverCheck() // Gameover player�n can� 0a d��t���nde olacak.
    {
        if (player.health >= 0)
        {
            GameOverStatus = true;
        }

    }
    void HitControl() // burada player alana girmi� durumda ise 1 saniye aral�kla hasar vuraca��z.
    {
        if (hitStatus)
        {
            Invoke("DamageToPlayer", 1.5f);    //Player alanda durdu�u her 1.5 saniye boyunca hasar yiyecek.
        }
    }

    void DamageToPlayer()
    {
        player.health -= 35;
    }
}
