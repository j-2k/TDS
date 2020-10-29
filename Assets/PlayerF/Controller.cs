using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float Playerspeed = 5;
    float x;
    float z;
    float rotx;
    public bool PS4C;

    void Update()
    {
        
        float x = Input.GetAxis("HorizontalLJS");
        float z = Input.GetAxis("VerticalLJS");

        rotx += Input.GetAxis("HorizontalRJS");

        transform.position += ((transform.right* x + transform.forward* z) * Playerspeed* Time.deltaTime);
        transform.rotation = Quaternion.Euler(new Vector3(0, rotx, 0));
    }
}
