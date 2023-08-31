using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Elevator : MonoBehaviour
{
    public float startintPoint;
    public float endingPoint;
    public float travellingTime;
    private void Start()
    {
        GoDown();
    }
    public void GoUp()
    {
        Sequence goUp = DOTween.Sequence();

        transform.DOMoveY(startintPoint, travellingTime);
        Invoke("GoDown", travellingTime + 5f);
    }

    public void GoDown()
    {
        Sequence goDown = DOTween.Sequence();

        transform.DOMoveY(endingPoint, travellingTime);
        Invoke("GoUp", travellingTime + 5f);
    }

    //Add evelator Stops|Floors

}
