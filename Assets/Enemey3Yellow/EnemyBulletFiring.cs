using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletFiring : MonoBehaviour
{
    public float EnemyBSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * EnemyBSpeed * Time.deltaTime);
        Destroy(gameObject, 5);

    }
}
