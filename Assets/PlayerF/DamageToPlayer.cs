using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    public int EnemyDamageToPlayer;

    void Start()
    {
        EnemyDamageToPlayer = 1;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            other.gameObject.GetComponent<PlayerHealth>().DamageToPlayer(EnemyDamageToPlayer);
        }
    }
}
