using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAction : MonoBehaviour
{
    public PlayerController player;
    private bool hitStatus=false;
    public bool GameOverStatus = false;

    IEnumerator hitCoroutine;
    void Start()
    {
        hitCoroutine = DamagePerSecond();
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("HitZone'a girildi");
            hitStatus = true;  
            StartCoroutine("DamagePerSecond");// Burada alana girdiðinde direkt hasar yemesin, gecikmeli olarak baþlasýn istedim.
        }

    }
    
    private void OnTriggerExit(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            hitStatus = false;
            StopCoroutine("DamagePerSecond"); // Alandan çýkýldýðýnda hasar yemesi engellenecek.
        }
    }


    void GameOverCheck() // Gameover playerýn caný 0a düþtüðünde olacak.
    {
        if ( player.health <= 0)
        {
            GameOverStatus = true;
        }

    }


    void DamageToPlayer()
    {
        Debug.Log("Damage atýldý.");
        player.health -= 35;
    }


    IEnumerator DamagePerSecond()
    {
        yield return new WaitForSeconds(3f);
        DamageToPlayer();
        yield return new WaitForSeconds(2f);
    }
}
