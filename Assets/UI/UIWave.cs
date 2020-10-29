using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIWave : MonoBehaviour
{
    public Text WaveText;
    float SecondsWave;

    void FixedUpdate()
    {
        SecondsWave += Time.deltaTime;
        if (SecondsWave <= 60)
        {
            WaveText.text = "Wave 1";
        }
        if (SecondsWave > 60)
        {
            WaveText.text = "Wave 2";
        }
        if (SecondsWave > 120)
        {
            WaveText.text = "Wave 3";
        }
    }
}
