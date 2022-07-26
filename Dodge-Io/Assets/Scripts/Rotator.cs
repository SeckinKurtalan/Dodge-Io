using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float speed = 70.0f;
    public GameObject fountain;
    int random = 0;
    int control = 1;
    float oldSpeed = 0.0f;
    void Start()
    {
        
    }

    void Update()
    {
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
            speed += 1;
        }
    }
}
