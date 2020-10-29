using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRNDScript : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    float Random1;
    float RandomPick;
    Vector3 SpawnLocation1;
    public float SpawnRate1 = 10f;
    public float SpawnRate2 = 5f;
    public float SpawnRate3 = 2f;
    float Wave1 = 0.0f;
    float Wave2 = 0.0f;
    float Wave3 = 0.0f;
    float Wave2Timer = 0f;
    float Wave3Timer = 0f;

    public bool Wave1enable = true;
    public bool Wave2enable = false;
    public bool Wave3enable = false;
    void Start()
    {
        SpawnRate1 = 10f;
        SpawnRate2 = 5f;
        SpawnRate3 = 2f;
    }
    void FixedUpdate()
    {
        Wave2Timer += Time.deltaTime;
        Wave3Timer += Time.deltaTime;

        if (Wave1enable == true)
        {
            if (Time.time > Wave1)
            {
                Wave1 = Time.time + SpawnRate1;
                Random1 = Random.Range(-10, 10);
                SpawnLocation1 = new Vector3(Random1, transform.position.y, transform.position.z);
                RandomPick = Random.Range(1, 4);
                if (RandomPick == 1)
                {
                    Instantiate(Enemy1, SpawnLocation1, Quaternion.identity);
                }
                if (RandomPick == 2)
                {
                    Instantiate(Enemy2, SpawnLocation1, Quaternion.identity);
                }
                if (RandomPick == 3)
                {
                    Instantiate(Enemy3, SpawnLocation1, Quaternion.identity);
                }
            }
        }

        if (Wave2Timer >= 60)
        {
            Wave1enable = false;
            Wave2enable = true;
            Wave3enable = false;

            if (Wave2enable == true)
            {
                if (Time.time > Wave2)
                {
                    Wave2 = Time.time + SpawnRate2;
                    Random1 = Random.Range(-10, 10);
                    SpawnLocation1 = new Vector3(Random1, transform.position.y, transform.position.z);
                    RandomPick = Random.Range(1, 4);
                    if (RandomPick == 1)
                    {
                        Instantiate(Enemy1, SpawnLocation1, Quaternion.identity);
                    }
                    if (RandomPick == 2)
                    {
                        Instantiate(Enemy2, SpawnLocation1, Quaternion.identity);
                    }
                    if (RandomPick == 3)
                    {
                        Instantiate(Enemy3, SpawnLocation1, Quaternion.identity);
                    }
                }
            }
        }

        if (Wave3Timer >= 120)
        {
            Wave1enable = false;
            Wave2enable = false;
            Wave3enable = true;

            if (Wave3enable == true)
            {
                if (Time.time > Wave3)
                {
                    Wave3 = Time.time + SpawnRate3;
                    Random1 = Random.Range(-10, 10);
                    SpawnLocation1 = new Vector3(Random1, transform.position.y, transform.position.z);
                    RandomPick = Random.Range(1, 4);
                    if (RandomPick == 1)
                    {
                        Instantiate(Enemy1, SpawnLocation1, Quaternion.identity);
                    }
                    if (RandomPick == 2)
                    {
                        Instantiate(Enemy2, SpawnLocation1, Quaternion.identity);
                    }
                    if (RandomPick == 3)
                    {
                        Instantiate(Enemy3, SpawnLocation1, Quaternion.identity);
                    }
                }
            }
        }
    }
}
