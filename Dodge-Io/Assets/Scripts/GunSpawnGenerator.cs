using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class GunSpawnGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] spawnAreas;
    [SerializeField] GameObject[] guns;
    int randomAreaIndex=0;
    int randomGun=0;
    public int spawnCount = 0;
    public List<GameObject> spawnedGuns;
    float distanceBetweenVectors;
    Vector3 randomPlace;
    Vector3 oldTransform;
    void Start()
    {
        InstantiateAGun();
        InstantiateAGun();
        InvokeRepeating(nameof(InstantiationController),0f,3f);


    }

    
    void Update()
    {
        
    }

    void InstantiateAGun()
    {
        
        randomGun = Random.Range(0, 5);
        randomAreaIndex = Random.Range(0, 4);
        oldTransform = randomPlace;
        distanceBetweenVectors = Vector3.Distance(randomPlace, oldTransform);
        while(distanceBetweenVectors < 4f)
        {
            randomPlace = new Vector3(Random.Range(spawnAreas[randomAreaIndex].transform.position.x - 35, spawnAreas[randomAreaIndex].transform.position.x + 35), 11f, Random.Range(spawnAreas[randomAreaIndex].transform.position.z - 35, spawnAreas[randomAreaIndex].transform.position.z + 35));
            distanceBetweenVectors = Vector3.Distance(randomPlace, oldTransform);
        }
        Instantiate(guns[randomGun],randomPlace,Quaternion.identity);
        spawnedGuns.Add(guns[randomGun]);
        spawnCount = spawnedGuns.Count;
    }

    void InstantiationController()
    {
        if(spawnCount < 4)
        {
            InstantiateAGun();
        }
        
    }

    
    
    

}
