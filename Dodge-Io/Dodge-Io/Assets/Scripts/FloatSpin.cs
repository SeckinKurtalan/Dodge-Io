using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FloatSpin : MonoBehaviour
{
    bool oh = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(2.0f, 2.0f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);

        transform.DORotate(new Vector3(0.0f, 360.0f, 0.0f), 5.0f, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetRelative()
            .SetEase(Ease.Linear);
    }


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player" && oh)
        {
            Debug.Log("msdlfkþlwf");
            oh = false;
        }
    } 

}
