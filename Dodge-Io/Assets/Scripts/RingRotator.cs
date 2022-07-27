using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RingRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DORotate(new Vector3(0f, 360f, 0f), 3f, RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart).SetEase(Ease.Linear);
        transform.DOMove(new Vector3(transform.position.x, transform.position.y+5f, transform.position.z), 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
