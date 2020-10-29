using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text ScoreText;
    public static int PlayerScore;

    void Update()
    {
        ScoreText.text = "Score: " + PlayerScore;
    }
}
