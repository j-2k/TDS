using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    public int PlayersHealth;
    public Text healthtext;

    void Update()
    {
        PlayersHealth = GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerHealth>().PlayerRealTimeHP;
        healthtext.text = "Health: " + PlayersHealth;
    }
}
