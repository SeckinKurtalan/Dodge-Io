using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float Health = 100;
    public string Name;
    public int Power = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BossPowerUp()
    {
        Power += 1;
    }
}
