using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Health : MonoBehaviour
{

    public int Enemy2StartingHP;

    //[HideInInspector]
    public int Enemy2RealTimeHP;

    int scoreValue = 20;

    // Start is called before the first frame update
    void Start()
    {
        Enemy2StartingHP = 20;
        Enemy2RealTimeHP = Enemy2StartingHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy2RealTimeHP <= 0)
        {
            UIScore.PlayerScore += scoreValue;
            Destroy(gameObject);
        }
    }

    public void DamagingEnemy2(int EnemyTakingDamage)
    {
        Enemy2RealTimeHP -= EnemyTakingDamage;
    }
}
