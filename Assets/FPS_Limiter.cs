using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Limiter : MonoBehaviour
{
    public bool max60FPS;
    public bool max120FPS;

    public void Update()
    {
        QualitySettings.vSyncCount = 1;
        if(max60FPS)
            Application.targetFrameRate = 60;
        if(max120FPS)
            Application.targetFrameRate = 120;

        //Debug.Log(Time.deltaTime);
        Time.timeScale = 1f;
    }
}
