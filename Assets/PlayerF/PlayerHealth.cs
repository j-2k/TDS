using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth: MonoBehaviour
{
    public int PlayerStartingHP;

    public int PlayerRealTimeHP;


    void Start()
    {
        PlayerStartingHP = 10;
        PlayerRealTimeHP = PlayerStartingHP;
    }

    void Update()
    {

        if(PlayerRealTimeHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void PlayerDamageFromBullet (int PlayerBulletDamage)
    {
        PlayerRealTimeHP -= PlayerBulletDamage;
    }

    public void DamageToPlayer(int PlayerTakingDamage)
    {
        PlayerRealTimeHP -= PlayerTakingDamage;
    }

    public void PlayerHPPickup(int PlayerHPGain)
    {
        PlayerRealTimeHP += PlayerHPGain;
    }
}
