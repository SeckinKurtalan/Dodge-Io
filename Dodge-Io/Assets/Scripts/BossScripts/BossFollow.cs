using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossFollow : MonoBehaviour
{
    public GameObject player;
    public bool hitAction = false;
    int random = 0;
    void Start()
    {
        
    }


    void Update()
    {

        Follow();

    }
    void Follow() // Burada boss hasar vurana kadar playera bakacak, vuru� yapaca��nda duracak ve vuru�unu yapacak, vuru�u bitince tekrar playera bakacak.
    {
        if (hitAction)
        {

        }
        else
        {
            transform.LookAt(player.transform.position);
        }
    }
}
