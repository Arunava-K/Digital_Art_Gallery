using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gate : MonoBehaviour
{ 
    public float delay;
    public float waitTime;

    private void Start()
    {
        
    }
    public void Open()
    {
        Sequence open = DOTween.Sequence();
        transform.DOMoveZ(transform.position.x + 5f, 5f);
        Invoke("Close", 5);
    }
    public void Close()
    {
    }
}
