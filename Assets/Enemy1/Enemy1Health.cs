using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{

    public int Enemy1StartingHP;

    //[HideInInspector]
    public int Enemy1RealTimeHP;

     int scoreValue = 10;

    // Start is called before the first frame update
    void Start()
    {

        Enemy1StartingHP = 10;
        Enemy1RealTimeHP = Enemy1StartingHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy1RealTimeHP <= 0)
        {
            UIScore.PlayerScore += scoreValue;
            Destroy(gameObject);
        }
    }

    public void DamagingEnemy1(int EnemyTakingDamage)
    {
        Enemy1RealTimeHP -= EnemyTakingDamage;
    }
}
