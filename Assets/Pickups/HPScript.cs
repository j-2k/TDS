using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPScript : MonoBehaviour
{

    public int HPPICKUP;

    // Start is called before the first frame update
    void Start()
    {
        HPPICKUP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 2f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            other.gameObject.GetComponent<PlayerHealth>().PlayerHPPickup(HPPICKUP);
            Destroy(gameObject);
        }
    }
}
