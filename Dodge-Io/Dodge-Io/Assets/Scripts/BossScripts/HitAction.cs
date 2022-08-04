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
            InvokeRepeating("HitStatusTrueMaker", 0.5f, 0.0f);  // Burada alana girdiðinde direkt hasar yemesin, gecikmeli olarak baþlasýn istedim.
        }

    }
    
    private void OnTriggerExit(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            hitStatus = false;
        }
    }


    void GameOverCheck() // Gameover playerýn caný 0a düþtüðünde olacak.
    {
        if ( player.health >= 0)
        {
            GameOverStatus = true;
        }

    }
    void HitControl() // burada player alana girmiþ durumda ise 1 saniye aralýkla hasar vuracaðýz.
    {
        if (hitStatus)
        {
            InvokeRepeating("DamageToPlayer",0.0f ,1f);    //Player alanda durduðu her 1 saniye boyunca hasar yiyecek.
        }
    }

    void DamageToPlayer()
    {
        Debug.Log("Damage atýldý.");
        player.health -= 35;
    }
    void HitStatusTrueMaker()
    {
        hitStatus = true;
    }

}
