using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    int speed = 50;
    public GameObject fountain;
    public GameObject hitzone;
    Vector3 sizeChange = new Vector3(1.0f, 0.0f, 0.0f );
    int random = 0;
    int control = 1;
    int oldSpeed = 0;
    int a = 0;
    int b = 0;
    int c = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (speed % 30 == 0 && a == b )
        {          
            if ( c < 7)
            {
                c++;
                SizeUp();
            }

            a++;
        }
        fountain.transform.Rotate(Vector3.up * speed * Time.deltaTime * control);
        random = Random.Range(1, 2001);
        RandomCheckAndSideChange();
        //Debug.Log(speed);
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
            if (speed % 30 != 0 && a != b)
            {
                b++;
            }
            control = control * -1;
            if (speed < 211)
            {
                speed += 10;
            }
            
        }
    }
    void SizeUp()
    {
        hitzone.transform.localScale += sizeChange;
    }
}
