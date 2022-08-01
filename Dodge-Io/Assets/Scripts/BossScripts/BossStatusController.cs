using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStatusController : MonoBehaviour
{
    public Transform bossBody;
    public int health = 100;
    public Vector3 rageModeBody;
    public int damageToBoss = 0;

    

    void Start()
    {
        rageModeBody.x = bossBody.transform.localScale.x; // Burada Rage haldeki bedenin deðerleri oluþturuluyor.
        rageModeBody.y = bossBody.transform.localScale.y;
        rageModeBody.z = bossBody.transform.localScale.z;
        rageModeBody.x *= 5;
        rageModeBody.y *= 5;
        rageModeBody.z *= 5;
    }

    // Update is called once per frame
    void Update()
    {

        BossRageCheck();
    }

    void BossRageCheck()    // Burada amacým bossun caný %40ýn altýna indiðinde boyutunun artmasý(Rage hali)
    {
        if (health <= 40)
        {
            bossBody.transform.localScale = rageModeBody;
            bossBody.transform.position = new Vector3(0, rageModeBody.y - 0.05f, 0);  // Burada boss büyüdüðünde yerin altýna girmesin diye pozisyon düzenlendi
        }
    }
    
}
