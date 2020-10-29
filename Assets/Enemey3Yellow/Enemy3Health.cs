using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Health : MonoBehaviour
{

    public int Enemy3StartingHP;

    //[HideInInspector]
    public int Enemy3RealTimeHP;

    int scoreValue = 30;

    // Start is called before the first frame update
    void Start()
    {
        Enemy3StartingHP = 10;
        Enemy3RealTimeHP = Enemy3StartingHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy3RealTimeHP <= 0)
        {
            UIScore.PlayerScore += scoreValue;
            Destroy(gameObject);
        }
    }

    public void DamagingEnemy3(int EnemyTakingDamage)
    {
        Enemy3RealTimeHP -= EnemyTakingDamage;
    }
}
