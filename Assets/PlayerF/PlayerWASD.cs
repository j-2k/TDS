using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : MonoBehaviour
{
    public float Playerspeed;

    Camera CameraDirection;

    void Start()
    {
        Playerspeed = 5;
        CameraDirection = FindObjectOfType<Camera>();
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1) * Playerspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * Playerspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1) * Playerspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * Playerspeed * Time.deltaTime;
        }
        
        Ray MouseDirection = CameraDirection.ScreenPointToRay(Input.mousePosition);
        Plane Floor = new Plane(Vector3.up, Vector3.zero);
        float RayDistance;

        if(Floor.Raycast(MouseDirection, out RayDistance))
        {
            Vector3 PlayerView = MouseDirection.GetPoint(RayDistance);
            Debug.DrawLine(MouseDirection.origin, PlayerView, Color.green);
            transform.LookAt(new Vector3(PlayerView.x, transform.position.y, PlayerView.z));
        }

    }
}
