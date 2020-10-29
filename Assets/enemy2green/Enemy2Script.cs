using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{

    private Rigidbody Enemy2RB;
    public float Enemy2Speed;
    public PlayerWASD AimAtPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Enemy2Speed = 4;
        Enemy2RB = GetComponent<Rigidbody>();
        AimAtPlayer = FindObjectOfType<PlayerWASD>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(AimAtPlayer.transform.position);
        Enemy2RB.velocity = transform.forward * Enemy2Speed;
    }
}
