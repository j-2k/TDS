using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Script : MonoBehaviour
{

    private Rigidbody Enemy1RB;
    public float Enemy1Speed;
    public PlayerWASD AimAtPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Enemy1Speed = 3;
        Enemy1RB = GetComponent<Rigidbody>();
        AimAtPlayer = FindObjectOfType<PlayerWASD>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(AimAtPlayer.transform.position);
        Enemy1RB.velocity = transform.forward * Enemy1Speed;
    }
}
