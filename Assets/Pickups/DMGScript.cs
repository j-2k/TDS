using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMGScript : MonoBehaviour
{
    public int DMGPickup;

    // Start is called before the first frame update
    void Start()
    {
        DMGPickup = 1;
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
            other.gameObject.GetComponentInChildren<BulletShooting>().DOUBLEDAMAGE(DMGPickup);
            Destroy(gameObject);
        }
    }
}
