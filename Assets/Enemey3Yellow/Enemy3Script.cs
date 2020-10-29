using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Script : MonoBehaviour
{

    private Rigidbody Enemy3RB;
    public float Enemy3Speed;
    public PlayerWASD AimAtPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Enemy3Speed = 2;
        Enemy3RB = GetComponent<Rigidbody>();
        AimAtPlayer = FindObjectOfType<PlayerWASD>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(AimAtPlayer.transform.position);
        Enemy3RB.velocity = transform.forward * Enemy3Speed;
    }
}
