using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{
    public Text TimerText;
    float Seconds;
    int Minute;

    void FixedUpdate()
    {
        Seconds += Time.deltaTime;
        TimerText.text = "M:" + Minute + "   S:" + (int) Seconds;
        if (Seconds >= 60)
        {
            Seconds = 0;
            Minute += 1;
        }
    }
}
