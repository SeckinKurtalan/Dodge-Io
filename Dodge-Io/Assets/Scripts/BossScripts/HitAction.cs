using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAction : MonoBehaviour
{
    public PlayerController player;
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
            Debug.Log("HitZone'a girildi");
            InvokeRepeating("HitStatusTrueMaker", 0.5f, 0.0f);  // Burada alana girdi�inde direkt hasar yemesin, gecikmeli olarak ba�las�n istedim.
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
        if ( player.health >= 0)
        {
            GameOverStatus = true;
        }

    }
    void HitControl() // burada player alana girmi� durumda ise 1 saniye aral�kla hasar vuraca��z.
    {
        if (hitStatus)
        {
            InvokeRepeating("DamageToPlayer",0.0f ,1f);    //Player alanda durdu�u her 1 saniye boyunca hasar yiyecek.
        }
    }

    void DamageToPlayer()
    {
        Debug.Log("Damage at�ld�.");
        player.health -= 35;
    }
    void HitStatusTrueMaker()
    {
        hitStatus = true;
    }

}
