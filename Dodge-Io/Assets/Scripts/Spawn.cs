using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ShotGun;
    public GameObject RPG;
    public GameObject FlameThrower;
    public GameObject Minigun;
    public GameObject LazerGun;

    public int gunAmount;
    int countGun=0;
    float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num = Random.Range(1,6);
        var position = new Vector3(Random.Range(-100, 100), 10, Random.Range(-100, 100));
        timer += Time.deltaTime;

        Debug.Log(num);
        if(timer>1)
        {
            Debug.Log(timer);
            timer = 0f;
            if (num == 1)
            {
                Instantiate(ShotGun, position, Quaternion.identity);
                ShotGun.SetActive(true);
                if (ShotGun != null)
                {
                    Destroy(ShotGun, 5.0f);
                }
            }
            else if (num == 2)
            {
                Instantiate(RPG, position, Quaternion.identity);
                RPG.SetActive(true);
                if (RPG != null)
                {
                    Destroy(RPG, 5.0f);
                }
            }
            else if (num == 3)
            {
                Instantiate(FlameThrower, position, Quaternion.identity);
                FlameThrower.SetActive(true);
                if (FlameThrower != null)
                {
                    Destroy(FlameThrower, 5.0f);
                }
            }
            else if (num == 4)
            {
                Instantiate(Minigun, position, Quaternion.identity);
                Minigun.SetActive(true);
                if (Minigun != null)
                {
                    Destroy(Minigun, 5.0f);
                }
            }
            else if (num == 5)
            {
                Instantiate(LazerGun, position, Quaternion.identity);
                LazerGun.SetActive(true);
                if (LazerGun != null)
                {
                    Destroy(LazerGun, 5.0f);
                }
            }
        }
    }
}
