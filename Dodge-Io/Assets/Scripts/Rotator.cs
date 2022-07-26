using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    int speed = 100;
    public GameObject fountain;
    public GameObject hitzone;
    int random = 0;
    int control = 1;
    int oldSpeed = 0;
    Vector3 scaleOfZone = new Vector3(2, 13, 0);
    
    void Start()
    {
        
    }

    void Update()
    {
        if (speed % 50 == 0)
        {

        }
        fountain.transform.Rotate(Vector3.up * speed * Time.deltaTime * control);
        random = Random.Range(1, 2001);
        RandomCheckAndSideChange();
        Debug.Log(speed);
    }
    void waitForTime()
    {
        StartCoroutine("waitTime");
    }
    
    IEnumerator waitTime() 
    { 
      yield return new WaitForSeconds(2f); 
    }

    void RandomCheckAndSideChange()
    {
        if (random == 500)
        {
            control = control * -1;
            speed += 2;
        }
    }
}
