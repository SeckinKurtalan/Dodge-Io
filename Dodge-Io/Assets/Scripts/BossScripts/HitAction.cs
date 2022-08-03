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
            StartCoroutine("DamagePerSecond");// Burada alana girdi�inde direkt hasar yemesin, gecikmeli olarak ba�las�n istedim.
        }

    }
    
    private void OnTriggerExit(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            hitStatus = false;
            StopCoroutine("DamagePerSecond"); // Alandan ��k�ld���nda hasar yemesi engellenecek.
        }
    }


    void GameOverCheck() // Gameover player�n can� 0a d��t���nde olacak.
    {
        if ( player.health <= 0)
        {
            GameOverStatus = true;
        }

    }


    void DamageToPlayer()
    {
        Debug.Log("Damage at�ld�.");
        player.health -= 35;
    }


    IEnumerator DamagePerSecond()
    {
        yield return new WaitForSeconds(3f);
        DamageToPlayer();
        yield return new WaitForSeconds(2f);
    }
}
