using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject Ring;
    
    public int ringCount=5;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Instantiate(Ring, new Vector3(Random.Range(-83, 92), 6.7f, Random.Range(-84, 88)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

        RingSpawn();
    }



    void RingSpawn()
    {
        if(ringCount < 3)
        {
            Instantiate(Ring, new Vector3(Random.Range(-83, 92), 6.7f, Random.Range(-84, 88)),Quaternion.identity);
            SpawnHold();
            ringCount++;
        }
    }

  IEnumerator timer()
    {
        yield return new WaitForSecondsRealtime(1f);
    }  

    void SpawnHold()
    {
        StartCoroutine("timer");
    }
}
