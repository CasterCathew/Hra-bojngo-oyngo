using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class TimeManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLength = 2f;
    private bool isSlowmotionActive = false;

    void Update()
    {
        if (isSlowmotionActive)
        {
           Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
            if (Time.timeScale >= 1f)
            {
                Time.timeScale = 1f;
                isSlowmotionActive = false;
            }
            Time.fixedDeltaTime = Time.timeScale * 0.02f;

        }
        
    }

    public void Slowmotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        isSlowmotionActive = true;
    }
 
}
