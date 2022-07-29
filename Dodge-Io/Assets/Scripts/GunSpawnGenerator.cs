using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawnGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] spawnAreas;
    [SerializeField] GameObject[] guns;
    int randomAreaIndex=0;
    int randomGun=0;
    public int spawnCount = 4;
    void Start()
    {
        InstantiateAGun();
        InstantiateAGun();
        InstantiateAGun();
        InstantiateAGun();
        
        
    }

    
    void Update()
    {
        InstantiationController();
    }

    void InstantiateAGun()
    {
        
        randomGun = Random.Range(0, 5);
        randomAreaIndex = Random.Range(0, 4);
        Vector3 randomPlace = new Vector3(Random.Range(spawnAreas[randomAreaIndex].transform.position.x-35, spawnAreas[randomAreaIndex].transform.position.x+35), 11f, Random.Range(spawnAreas[randomAreaIndex].transform.position.z - 35, spawnAreas[randomAreaIndex].transform.position.z + 35));
        Instantiate(guns[randomGun],randomPlace,Quaternion.identity);
    }

    void InstantiationController()
    {
        if(spawnCount < 3)
        {
            for(int i = 0; i < 3; i++)
            {
                InstantiateAGun();
                StartCoroutine("Wait");
                spawnCount++;
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
    }
    
    

}
