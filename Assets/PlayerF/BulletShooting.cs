using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{

    public bool GunTrigger = false;
    public bool Gun1 = true;
    public bool Gun2 = false;
    public bool Gun3 = false;
    public BulletFiring Bullet;
    public float SpeedOfBullet;
    public float SpeedOfBullet2;
    public float SpeedOfBullet3;
    public Transform BulletLocation;

    public int BulletDamage;

    public float Shotstimer;
    float Shots;

    void Start()
    {
        SpeedOfBullet = 5;
        SpeedOfBullet2 = 20;
        SpeedOfBullet3 = 10;
        BulletDamage = 1;
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            GunTrigger = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            GunTrigger = false;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            GunTrigger = true;
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button7))
        {
            GunTrigger = false;
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            Gun1 = true;
            Gun2 = false;
            Gun3 = false;
            Debug.Log("pressing1openingg1");
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            Gun1 = false;
            Gun2 = true;
            Gun3 = false;
            Debug.Log("pressingg2openining2");
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Gun1 = false;
            Gun2 = false;
            Gun3 = true;
            Debug.Log("pressingg3openining3");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Gun1 = true;
            Gun2 = false;
            Gun3 = false;
            Debug.Log("pressing1openingg1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Gun1 = false;
            Gun2 = true;
            Gun3 = false;
            Debug.Log("pressingg2openining2");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Gun1 = false;
            Gun2 = false;
            Gun3 = true;
            Debug.Log("pressingg3openining3");
        }

        if (Gun1 == true)
        {
            Debug.Log("gun1 is open");
            Shotstimer = 0.25f;
            if (GunTrigger == true)
            {
                Shots -= Time.deltaTime;
                if(Shots <= 0)
                {
                    Shots = Shotstimer;
                    BulletFiring newBullet = Instantiate(Bullet, BulletLocation.position, BulletLocation.rotation) as BulletFiring;
                    newBullet.Speed = SpeedOfBullet;
                }
            }
            else
            {
                Shots = 0;
            }
        }

        if (Gun2 == true)
        {
            Debug.Log("Gun2 is Open");
            Shotstimer = 1f;
            if (GunTrigger == true)
            {
                Shots -= Time.deltaTime;
                if (Shots <= 0)
                {
                    Shots = Shotstimer;
                    BulletFiring newBullet = Instantiate(Bullet, BulletLocation.position, BulletLocation.rotation) as BulletFiring;
                    newBullet.Speed = SpeedOfBullet2;
                }
            }
            else
            {
                Shots = 0;
            }

        }

        if (Gun3 == true)
        {
            Debug.Log("gun3 is open");
            Shotstimer = 0.5f;
            if (GunTrigger == true)
            {
                Shots -= Time.deltaTime;
                if (Shots <= 0)
                {
                    Shots = Shotstimer;
                    BulletFiring newHBullet = Instantiate(Bullet, BulletLocation.position, BulletLocation.rotation) as BulletFiring;
                    newHBullet.Speed = SpeedOfBullet3;
                }
            }
            else
            {
                Shots = 0;
            }
        }

    }


    void OnCollisionEnter(Collision BulletCollision)
    {
        if (BulletCollision.gameObject.tag == "Enemy1")
        {
            BulletCollision.gameObject.GetComponent<Enemy1Health>().DamagingEnemy1(BulletDamage);
            Destroy(gameObject);
        }

        if (BulletCollision.gameObject.tag == "Enemy2")
        {
            BulletCollision.gameObject.GetComponent<Enemy2Health>().DamagingEnemy2(BulletDamage);
            Destroy(gameObject);
        }

        if (BulletCollision.gameObject.tag == "Enemy3")
        {
            BulletCollision.gameObject.GetComponent<Enemy3Health>().DamagingEnemy3(BulletDamage);
            Destroy(gameObject);
        }
    }

    public void DOUBLEDAMAGE(int DPSGAIN)
    {
            BulletDamage += DPSGAIN;
    }
}
