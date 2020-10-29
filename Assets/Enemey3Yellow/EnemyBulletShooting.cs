using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletShooting : MonoBehaviour
{
    bool EnemyGunTrigger = true;

    public EnemyBulletFiring EnemyBullet;
    public float EnemySpeedOfBullet;
    public Transform EnemyBulletLocation;

    public int EnemyBulletDamage;

    public float EnemyShotstimer;
    float EnemyShots;

    void Start()
    {
        EnemySpeedOfBullet = 4;
        EnemyShotstimer = 3f;
        EnemyBulletDamage = 1;
    }

    void Update()
    {
        if (EnemyGunTrigger == true)
        {
            EnemyShots -= Time.deltaTime;
            if(EnemyShots <= 0)
            {
                EnemyShots = EnemyShotstimer;
                EnemyBulletFiring enemynewBullet = Instantiate(EnemyBullet, EnemyBulletLocation.position, EnemyBulletLocation.rotation) as EnemyBulletFiring;
                enemynewBullet.EnemyBSpeed = EnemySpeedOfBullet;
            }
        }
        else
        {
            EnemyShots = 0;
        }  

    }

    void OnCollisionEnter(Collision BulletCollision)
    {
        if (BulletCollision.gameObject.tag == "Player1")
        {
            BulletCollision.gameObject.GetComponent<PlayerHealth>().PlayerDamageFromBullet(EnemyBulletDamage);
            Destroy(gameObject);
        }
    }
}
